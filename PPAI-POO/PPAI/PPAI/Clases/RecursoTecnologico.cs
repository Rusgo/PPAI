using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.AccesoDatos;

namespace PPAI
{
    public class RecursoTecnologico     //DEFINO LA CLASE 
    {
        private int Id;
        private int numeroRT;
        private TipoRecursoTecnologico tipoRecursoTecnologico;
        private Modelo modelo;
        private List<CambioEstadoRT> cambioEstadoRT;
        private Estado estadoActual;
        private List<Turno> turnos;

        //CONSTRUCTOR DE LA CLASE

        public RecursoTecnologico(int numeroRT, TipoRecursoTecnologico tipoRecursoTecnologico, Modelo modelo, List<CambioEstadoRT> cambioEstadoRT, List<Turno> turnos, Estado estadoActual)
        {
            this.numeroRT = numeroRT;
            this.tipoRecursoTecnologico = tipoRecursoTecnologico;
            this.modelo = modelo;
            this.cambioEstadoRT = cambioEstadoRT;
            this.turnos = turnos.ToList();
            this.estadoActual = estadoActual;
        }

        public RecursoTecnologico() { }

        //GETTERS Y SETTERS
        public int id { get => Id; set => Id = value; }
        public int NumeroRT { get => numeroRT; set => numeroRT = value; }
        public TipoRecursoTecnologico TipoRecursoTecnologico{ get => tipoRecursoTecnologico; set => tipoRecursoTecnologico = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public List<CambioEstadoRT> CambioEstadoRT { get => cambioEstadoRT; set => cambioEstadoRT = value; }
        public List<Turno> Turnos { get => turnos; set => turnos = value; }
        public Estado EstadoActual{ get => estadoActual; set => estadoActual = value; }

        public bool esTuTipo(TipoRecursoTecnologico tipoRTSeleccionado) //VERIFICA SI ES DEL TIPO ENVIADO POR PARAMETRO
        {
            bool resultado = false;
            if (this.TipoRecursoTecnologico.Nombre == tipoRTSeleccionado.Nombre)
            {
                resultado = true;
            }
            return resultado;
        }

        public bool esActivo() //VERIFICA QUE EL RECURSO TECNOLOGICO SEA RESERVABLE (ES DECIR, QUE NO TENGA ESTADO 'DADO DE BAJA TECNICA' O 'DADO DE BAJA DEFINITIVA')
        {
            //ESTADO DISPONIBLE ES QUE ESTA ACTIVO????
            return true; //(estadoActual.GetType() == typeof(Clases.Disponible));

        }

        public int getNumeroInventario() // DEVUELVE EL NUMERO DE INVENTARIO DEL RT
        {
            return this.numeroRT;
        }

        /*public CentroDeInvestigacion getCI(RecursoTecnologico recursoTecnologico)
        {
            using (Contexto.Context ctx = new Contexto.Context())
            {
                List<CentroDeInvestigacion> lista = ctx.CentroDeInvestigacion.Include("recursoTecnologico").Include("cientificos").ToList();
                foreach (CentroDeInvestigacion ci in lista)
                {
                    if (ci.esTuRecurso(this))
                    {
                        return ci;
                    }

                }
                return null;
            }
            
        }*/
        

        public List<string> getMarcaYModelo() // DEVUELVE LA MARCA Y EL MODELO DEL RT
        {
            
                
                return modelo.getMarcaYModelo();
            
        }

        public List<string> getDatos(RecursoTecnologico recursoTecnologico)                                   //OBTIENE LOS DATOS DEL RECURSO TECNOLOGICO  Y DEVUELVE UNA LISTA QUE CONTIENE LOS DATOS DE LOS RT RESERVABLES
        {
            
                List<string> listaDatosRTReservables = new List<string>();
                listaDatosRTReservables.Add(getNumeroInventario().ToString());

                
                List<string> listaModeloYMarca = getMarcaYModelo();
                

                foreach (string str in listaModeloYMarca)
                {
                    listaDatosRTReservables.Add(str);
                }
                listaDatosRTReservables.Add(estadoActual.obtenerNombre());

                return listaDatosRTReservables;
            
        }

        public bool sosRT(int numeroRT)                                                    //VERIFICA QUE ES EL RT ENVIADO POR PARAMETRO              
        {
            bool resultado = false;
            if (numeroRT == this.getNumeroInventario())
            {
                resultado = true;
            }
            return resultado;
        }

        public bool perteneceAEsteCI(PersonalCientifico cientificoLogueado, CentroDeInvestigacion ciDelRTSeleccionado)   //CONSULTA SI EL CIENTIFICO PERTENCE AL CI DEL RT SELECCIONADO
        {
            return (ciDelRTSeleccionado.esCientificoActivo(cientificoLogueado));


        }

        public List<List<string>> obtenerTurnos()                                                       //DEVUELVE LISTA CON LOS TURNOS DEL RT POSTERIORES A LA FECHA ACTUAL 
        {
            using (Contexto.Context ctx = new Contexto.Context())
            {
                List<List<string>> listaDatosTurnos = new List<List<string>>();
                foreach (Turno turno in this.turnos)
                {
                    Turno turnoFull = ctx.Turnos.Include("cambioEstadoTurno").Include("estadoActual").Where(x=>x.id == turno.id).FirstOrDefault();
                    if (turnoFull.esPosteriorALaFecha())
                    {
                        listaDatosTurnos.Add(turnoFull.getTurno());
                    }

                }

                return listaDatosTurnos;
            }
            

        }

        public Turno esTurno(string fechaHoraInicio, string fechaHoraFin)                               //VERIFICA QUE EL TURNO ENVIADO POR PARAMETRO PERTENECE A LOS TURNOS DEL RT
        {
            foreach (Turno turno in Turnos)
            {
                if (turno.esTurno(fechaHoraInicio, fechaHoraFin))
                {
                    using (Contexto.Context ctx = new Contexto.Context())
                    {
                        Turno turnoFull = ctx.Turnos.Include("estadoActual").Include("cambioEstadoTurno").Where(x => x.id == turno.id).FirstOrDefault();
                        return turnoFull;
                    }
                    
                }
                
            }
            return null;
        }

        //estado a asignar se puede ir
        public void reservar(Turno turnoSeleccionado, PersonalCientifico cientificoLogueado, DateTime date)      //CAMBIA EL ESTADO DEL TURNO SELECCIONADO A RESERVADO Y LO ASIGNA AL CENTRO DE INVESTIGACION
        {
           //recuperamos los datos necesarios para trabajar con el turno
            using (Contexto.Context ctx = new Contexto.Context())
            {
                Turno tFull = ctx.Turnos.Include("cambioEstadoTurno").Include("estadoActual").Where(x => x.id == turnoSeleccionado.id).FirstOrDefault();
                //llamamos al metodo del turno que va a invocar al metodo del estado 
                tFull.reservar(date, this, cientificoLogueado);      
                //guardamos cambios
                ctx.Entry(tFull).State = EntityState.Modified;
                ctx.SaveChanges();
            }

        }

    }

}

