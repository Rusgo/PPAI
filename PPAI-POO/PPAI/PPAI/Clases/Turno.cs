using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class Turno      //DEFINO LA CLASE 
    {
        private int Id;
        private string diaSemana;
        private DateTime fechaGeneracion;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private List<CambioEstadoTurno> cambioEstadoTurno;
        private Estado estadoActual;

        //CONSTRUCTOR DE LA CLASE

        public Turno(DateTime fechaGeneracion, string diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin, List<CambioEstadoTurno> cambioEstadoTurno,Estado estadoActual)
        {
            this.diaSemana = diaSemana;
            this.fechaGeneracion = fechaGeneracion;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.cambioEstadoTurno = cambioEstadoTurno.ToList();
            this.EstadoActual = estadoActual;
        }

        public Turno() { }

        //GETTERS Y SETTERS
        public int id { get => Id; set => Id = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
        public DateTime FechaGeneracion { get => fechaGeneracion; set => fechaGeneracion = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public List<CambioEstadoTurno> CambioEstadoTurno { get => cambioEstadoTurno; set => cambioEstadoTurno = value; }
        public Estado EstadoActual { get => estadoActual; set => estadoActual = value; }


        public bool esPosteriorALaFecha()         //VERIFICA QUE EL TURNO TIENE UNA FECHAHORAINICIO POSTERIOR A LA ACTUAL   
        {
            return (this.FechaHoraInicio > DateTime.Today);
        }

        public List<string> getTurno()      //DEVUELVE LOS DATOS DEL TURNO
        {
            List<string> listaDatosTurno = new List<string>();
            
                string nombreEstado = "";
                if (estadoActual.GetType() == typeof(Clases.Disponible))
                {
                    listaDatosTurno.Add(this.fechaHoraInicio.ToString());
                    listaDatosTurno.Add(this.FechaHoraFin.ToString());
                    nombreEstado = estadoActual.obtenerNombre();
                    listaDatosTurno.Add(nombreEstado);
                }
            
            return listaDatosTurno;
        }

        public bool esTurno(string fechaHoraInicio, string fechaHoraFin)
        {
            return (this.fechaHoraInicio == DateTime.Parse(fechaHoraInicio) && this.fechaHoraFin == DateTime.Parse(fechaHoraFin));
        }

        public void reservar(DateTime date, RecursoTecnologico rt,PersonalCientifico c)                   //SETEA LA FECHAHORAFIN EN EL CAMBIO ESTADO ANTERIOR Y CREA UN NUEVO CAMBIO ESTADO
        {
            // delega al estado actual
            estadoActual.reservar(this,cambioEstadoTurno,date,rt,this, c);
        }
        public void agregarCE(CambioEstadoTurno ce)
        {
            this.cambioEstadoTurno.Add(ce);
        }
    }
}
