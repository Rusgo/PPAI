using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoDatos;
using PPAI.Forms;
using PPAI;
using System.Windows.Forms;
using System.Data.Entity;

namespace PPAI
{
    public class GestorRegistrarReserva //DEFINO LA CLASE GESTOR
    { 
        private PantallaRegistrarReserva pantallaRegistrarReserva;
        private Sesion sesionActual;
        private TipoRecursoTecnologico tipoRTSeleccionado;
        private RecursoTecnologico rtSeleccionado;
        private bool pertenenciaDeCientificoACI;
        private CentroDeInvestigacion ciDelRTSeleccionado;
        private PersonalCientifico cientificoLogueado;
        private DateTime fechaActual;
        private string fechaSeleccionada;
        private List<List<string>> listaDatosTurnos;
        private Turno turnoSeleccionado;
        private Estado estadoAAsignar;
        private string marcaRTSeleccionado;
        private string modeloRTSeleccionado;

        //GETTERS Y SETTERS
        public PantallaRegistrarReserva PantallaRegistrarReserva { get => pantallaRegistrarReserva; set => pantallaRegistrarReserva = value; }
        public Sesion SesionActual { get => sesionActual; set => sesionActual = value; }
        public TipoRecursoTecnologico TipoRTSeleccionado { get => tipoRTSeleccionado; set => tipoRTSeleccionado = value; }

        // METODOS

        public GestorRegistrarReserva() { }

        public GestorRegistrarReserva(PantallaRegistrarReserva pantalla)                                                    //SETEA EL PUNTERO A PANTALLA CON LA PANTALLA QUE RECIBE COMO PARAMETRO
        {
            pantallaRegistrarReserva = pantalla;

        }

        public void tomarOpcionReservarTurnoRT()                                                                             //METODO QUE INICIA LA BUSQUEDA DE TIPOS DE RECURSO TECNOLOGICO
        {

            List<String> listaNombresTiposRT = buscarTiposRT();
            pantallaRegistrarReserva.mostrarTiposRT(listaNombresTiposRT);                                                //SE LLAMA A METODOS DE LA PANTALLA PARA INICIAR UNA NUEVA INTERACCION
            pantallaRegistrarReserva.solicitarSeleccionTipoRT();

        }
        public List<String> buscarTiposRT() {                                                                            //SE RECUPERAN LOS OBJETOS DE TIPO RT DE OBJETOSCREADOS Y SE AGREGAN A UNA LISTA

            List<String> listaNombresTiposRT = new List<String>();
            
            using (var ctx = new Contexto.Context())
            {
                var tiposRt = ctx.TiposRecursosTecnologicos.ToList();
                foreach (TipoRecursoTecnologico tipoRT in tiposRt)
                {
                    listaNombresTiposRT.Add(tipoRT.getNombre());
                }

                return listaNombresTiposRT;
            }
            

        }


        public void tomarSeleccionTipoRT(string seleccionTipoRT)                                                        //BUSCA Y GUARDA EL TIPO RT SELECCIONADO

        {
            this.tipoRTSeleccionado = null;
            using (var ctx = new Contexto.Context())
            {
                var tiposRt = ctx.TiposRecursosTecnologicos.ToList();
                foreach (TipoRecursoTecnologico tipoRT in tiposRt)
                {
                    foreach (TipoRecursoTecnologico trt in tiposRt)
                    {
                        if (trt.sosTipoRT(seleccionTipoRT) && this.tipoRTSeleccionado == null)                                                               //PATRON EXPERTO - EL TIPORT SABE SI ES DE ESE TIPO
                        {
                            this.tipoRTSeleccionado = trt;
                            break;
                        }
                    }
                }


            }

            List<List<string>> datosRT = buscarRTporTipoRT(tipoRTSeleccionado);
            pantallaRegistrarReserva.mostrarRT(datosRT);
            pantallaRegistrarReserva.solicitarSeleccionRT();

        }

        public List<List<string>> buscarRTporTipoRT(TipoRecursoTecnologico tipoRTSeleccionado)                      //OBTIENE TODOS LOS RT DEL TIPORTSELECCIONADO PARA CADA CI 
        {
            List<List<string>> datosRT = new List<List<string>>();
            using (var ctx = new Contexto.Context())
            {
                var CI = ctx.CentroDeInvestigacion.Include("RecursoTecnologico").ToList();
                foreach (CentroDeInvestigacion CENTRO in CI)
                {
                    datosRT = CENTRO.tieneRTDelTipoRTSeleccionado(tipoRTSeleccionado, datosRT);
                }
                agruparPorCI(datosRT);
                return datosRT;
            }


        }

        public List<List<string>> agruparPorCI(List<List<string>> lista)                                            //COMPARA TODOS LOS ELEMENTOS DE LA LISTA ENTRE SI (EN ESTE CASO POR EL PRIMER ELEMENTO DE LA SUBLISTA) Y LOS ORDENA
        {
            lista.Sort((x, y) => string.Compare(x[0], y[0]));
            return lista;
        }

        public void tomarSeleccionRT(string nombreCIdeRTSeleccionado, int numeroRT)           // GUARDA EL RT SELECCIONADO, Y BUSCA LOS TURNOS DEL MISMO                      
        {
            using (var ctx = new Contexto.Context())
            {
                //NO DEJAR EN BLANCO SOY BOLUDO
                List<CentroDeInvestigacion> CI = ctx.CentroDeInvestigacion.Include("recursoTecnologico").Include("cientificos").ToList();

                foreach (CentroDeInvestigacion CENTRO in CI)
                {
                    if (CENTRO.Nombre == nombreCIdeRTSeleccionado)
                    {
                        foreach (RecursoTecnologico rt in CENTRO.RecursoTecnologico)
                        {
                            if (rt.sosRT(numeroRT))
                            {
                                RecursoTecnologico rtFull = ctx.RecursosTecnologicos.Include("TipoRecursoTecnologico").Include("cambioEstadoRT").Include("turnos").Include("modelo").Where(x => x.id == rt.id).FirstOrDefault();
                                this.rtSeleccionado = rtFull;
                                this.ciDelRTSeleccionado = CENTRO;
                                break;
                            }
                            else
                            {
                                this.rtSeleccionado = null;
                            }
                        }
                    }
                }
                getUsuarioSesionActual();
                obtenerTurnosRT(pertenenciaDeCientificoACI);
            }

        }

        public void getUsuarioSesionActual()        //BUSCA Y GUARDA AL CIENTIFICO LOGUEADO
        {
            using (var ctx = new Contexto.Context())
            {
                DateTime d = DateTime.Parse("01/01/1900");
                Sesion sesionActual = ctx.Sesiones.Include("usuario").Where(x => x.FechaHoraFin == d).FirstOrDefault();
                this.sesionActual = sesionActual;
                cientificoLogueado = sesionActual.getCientifico();
                pertenenciaDeCientificoACI = rtSeleccionado.perteneceAEsteCI(cientificoLogueado, ciDelRTSeleccionado);
            }


        }

        public void obtenerTurnosRT(bool pertenenciaDeCientificoACI)                            //OBTIENE LOS TURNOS DEL RECURSO TECNOLOGÍCO SELECCIONADO POSTERIORES A LA FECHA/HORA ACTUAL , AGRUPANDOLOS Y ORDENANDOLOS 
        {
            this.fechaActual = getFechaActual();
            this.listaDatosTurnos = rtSeleccionado.obtenerTurnos();
            ordenarYAgruparTurnos(listaDatosTurnos);
        }

        public DateTime getFechaActual()        //OBTIENE LA FECHA ACTUAL
        {
            return DateTime.Today;
        }

        public void ordenarYAgruparTurnos(List<List<string>> listaDatosTurnos)  //ORDENA Y AGRUPA LOS TURNOS POR RT
        {
            List<DateTime> listaDias = new List<DateTime>();
            for (int i = 0; i < 30; i++)
            {
                listaDias.Add(DateTime.Now.AddDays(i));             //GENERA UNA LISTA CON LOS PROXIMOS 30 DIAS
            }

            List<int> listaContadores = new List<int>();


            for (int i = 0; i < listaDias.Count; i++)
            {
                int contador = 0;
                if (listaDatosTurnos.Count > i)
                {
                    if (listaDatosTurnos[i].Count > 0)
                    {
                        for (int fila = 0; fila < listaDatosTurnos.Count; fila++)
                        {
                            // validar que si esta vacia no haga eso
                            if (listaDatosTurnos[fila].Count > 0)
                            {
                                if (listaDias[i].Date == (DateTime.Parse(listaDatosTurnos[fila][0])).Date && listaDatosTurnos[fila][2].ToString() == "Disponible")
                                {
                                    contador += 1;              //POR CADA TURNO SE FIJA SI COINCIDE CON EL DIA Y SI ES DISPONIBLE Y AUMENTA EL CONTADOR DEL DIA
                                }
                            }

                        }

                    }

                }
                listaContadores.Add(contador);




            }
            

            pantallaRegistrarReserva.mostrarFechas(listaDias, listaContadores);
            pantallaRegistrarReserva.solicitarSeleccionFecha();

        }

        public void tomarSeleccionFecha(string fecha)                               // GUARDA LA FECHA SELECCIONADA, E INVOCA EL METODO DE LA PANTALLA PARA MOSTRAR LOS TURNOS DE ESA FECHA 
        {
            List<List<string>> turnosXFecha = new List<List<string>>();
            this.fechaSeleccionada = fecha;
            for (int fila = 0; fila < listaDatosTurnos.Count; fila++)
            {
                if (listaDatosTurnos[fila].Count > 0 && DateTime.Parse(fecha).Date == (DateTime.Parse(listaDatosTurnos[fila][0])).Date)
                {
                    turnosXFecha.Add(listaDatosTurnos[fila]);
                }
            }
            pantallaRegistrarReserva.mostrarTurnos(turnosXFecha);
        }

        public void tomarSeleccionTurno(string fechaHoraInicio, string fechaHoraFin)                                       // GUARDA EL TURNO SELECCIONADO, E INVOCA EL METODO DE LA PANTALLA PARA SOLICITAR LA CONFIRMACION DE LA RESERVA
        {
            this.turnoSeleccionado = rtSeleccionado.esTurno(fechaHoraInicio, fechaHoraFin);
            pantallaRegistrarReserva.solicitarConfirmacionReserva();

        }


        //Metodo de enganche
        public void tomarConfirmacionReserva(bool whatsapp, bool mail)                                                       //TOMA LA CONFIRMACION Y DISPARA EL METODO PARA LA GENERACION DE LA RESERVA
        {
            List<String> marcaModelo = this.rtSeleccionado.getMarcaYModelo();

            this.marcaRTSeleccionado = marcaModelo[0];
            this.modeloRTSeleccionado = marcaModelo[1];

            string mensaje = "¿Está seguro que desea confirmar el turno con fecha hora inicio: " + turnoSeleccionado.FechaHoraInicio.ToString() + " y fecha hora fin: " +
                turnoSeleccionado.FechaHoraFin.ToString() + " para el Recurso Tecnológico: " + rtSeleccionado.TipoRecursoTecnologico.Nombre.ToString() + " Nro. inventario: " +
                rtSeleccionado.NumeroRT.ToString() + " Modelo: " + modeloRTSeleccionado + " Marca: " + marcaRTSeleccionado + "?";
            if (MessageBox.Show(mensaje, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                generarReservaRT(whatsapp, mail);
            }
            


        }

        //sacarAlPingoooooo
        public void getEstadoReservado()  //OBTIENE EL PUNTERO DEL ESTADO RESERVADO
        {
            foreach (Estado estado in ObjetosCreados.Estados)
            {

                this.estadoAAsignar = estado;

            }
        }

        public void generarReservaRT(bool whatsapp, bool mail)                             //CAMBIA EL ESTADO DEL TURNO SELECCIONADO A RESERVADO Y LO ASIGNA AL CENTRO DE INVESTIGACION
        {
            //getEstadoReservado();
            DateTime date = new DateTime();
            date = DateTime.Now;
            /////////////////////////////////////////////////////////////////////////////////
            //se inicia la reserva
            rtSeleccionado.reservar(this.turnoSeleccionado, this.cientificoLogueado, date);
            /////////////////////////////////////////////////////////////////////////////////
            generarNotificacionParaCientifico(whatsapp, mail);
            using (var ctx = new Contexto.Context())
            {
                ctx.Entry(rtSeleccionado).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void generarNotificacionParaCientifico(bool whatsapp, bool mail)         //GENERA LA O LAS NOTIFICACIONES PARA EL CIENTIFICO SEGUN LA SELECCION DE LOS MÉTODOS
        {
            string mailCientifico = this.cientificoLogueado.getMail();
            string numeroWhatsApp = this.cientificoLogueado.getNumeroTelefono().ToString();

            if (whatsapp)
            {
                InterfazWhatsApp InterfazWhatsApp = new InterfazWhatsApp();
                InterfazWhatsApp.enviarNotificacionReserva(numeroWhatsApp, this.rtSeleccionado, this.turnoSeleccionado, this.marcaRTSeleccionado, this.modeloRTSeleccionado);


            }

            if (mail) {
            InterfazMail InterfazMail = new InterfazMail();
            InterfazMail.enviarNotificacionReserva(mailCientifico, this.rtSeleccionado, this.turnoSeleccionado, this.marcaRTSeleccionado, this.modeloRTSeleccionado);
            }
            //CERRAMOS SESION
            using (Contexto.Context ctx = new Contexto.Context())
            {
                this.sesionActual.FechaHoraFin = DateTime.Now;
                ctx.Entry(sesionActual).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            finCU();
    }


        public void finCU()     //FINALIZA EL CU
        {
            
            pantallaRegistrarReserva.Dispose();
        }
    }
}