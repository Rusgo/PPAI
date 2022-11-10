using System;
using System.Collections.Generic;
using System.Data;
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
        private CambioEstadoRT cambioEstadoActual;
        private List<Turno> turnos;

        //CONSTRUCTOR DE LA CLASE

        public RecursoTecnologico(int numeroRT, TipoRecursoTecnologico tipoRecursoTecnologico, Modelo modelo, List<CambioEstadoRT> cambioEstadoRT, List<Turno> turnos)
        {
            this.numeroRT = numeroRT;
            this.tipoRecursoTecnologico = tipoRecursoTecnologico;
            this.modelo = modelo;
            this.cambioEstadoRT = cambioEstadoRT;
            this.turnos = turnos.ToList();
        }

        public RecursoTecnologico() { }

        //GETTERS Y SETTERS
        public int id { get => Id; set => Id = value; }
        public int NumeroRT { get => numeroRT; set => numeroRT = value; }
        public TipoRecursoTecnologico TipoRecursoTecnologico{ get => tipoRecursoTecnologico; set => tipoRecursoTecnologico = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public List<CambioEstadoRT> CambioEstadoRT { get => cambioEstadoRT; set => cambioEstadoRT = value; }
        public List<Turno> Turnos { get => turnos; set => turnos = value; }

        public bool esTuTipo(TipoRecursoTecnologico tipoRTSeleccionado) //VERIFICA SI ES DEL TIPO ENVIADO POR PARAMETRO
        {
            bool resultado = false;
            if (this.TipoRecursoTecnologico == tipoRTSeleccionado)
            {
                resultado = true;
            }
            return resultado;
        }

        public bool esActivo() //VERIFICA QUE EL RECURSO TECNOLOGICO SEA RESERVABLE (ES DECIR, QUE NO TENGA ESTADO 'DADO DE BAJA TECNICA' O 'DADO DE BAJA DEFINITIVA')
        {
            cambioEstadoActual = null;
            foreach (CambioEstadoRT cambioEstado in cambioEstadoRT) {

                if (cambioEstado.esActual())
                {
                    cambioEstadoActual = cambioEstado;
                    break;
                }
            }
            return cambioEstadoActual.esEstadoActualReservable();

        }

        public int getNumeroInventario() // DEVUELVE EL NUMERO DE INVENTARIO DEL RT
        {
            return this.numeroRT;
        }

        public CentroDeInvestigacion getCI(RecursoTecnologico recursoTecnologico)
        {
            foreach ( CentroDeInvestigacion ci in ObjetosCreados.CentrosInvestigacion)
            { 
                if (ci.esTuRecurso(this))
                {
                    return ci;
                }
                
            }
            return null;
        }
        

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
            listaDatosRTReservables.Add(cambioEstadoActual.getEstado());

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
            List<List<string>> listaDatosTurnos = new List<List<string>>();
            foreach (Turno turno in this.turnos)
            {
                if (turno.esPosteriorALaFecha())
                {
                    listaDatosTurnos.Add(turno.getTurno()) ;
                }
                
            }

            return listaDatosTurnos;

        }

        public Turno esTurno(string fechaHoraInicio, string fechaHoraFin)                               //VERIFICA QUE EL TURNO ENVIADO POR PARAMETRO PERTENECE A LOS TURNOS DEL RT
        {
            foreach (Turno turno in Turnos)
            {
                if (turno.esTurno(fechaHoraInicio, fechaHoraFin))
                {
                    return turno;
                }
                
            }
            return null;
        }

        public void reservar(Turno turnoSeleccionado, Estado estadoAAsignar, PersonalCientifico cientificoLogueado, DateTime date)      //CAMBIA EL ESTADO DEL TURNO SELECCIONADO A RESERVADO Y LO ASIGNA AL CENTRO DE INVESTIGACION
        {
            turnoSeleccionado.reservar(date);
            CentroDeInvestigacion ci = getCI(this);
            ci.asignarTurno(turnoSeleccionado, cientificoLogueado);
        }

    }

}

