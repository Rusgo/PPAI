using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PPAI
{
    public class CambioEstadoTurno      //DEFINO LA CLASE
    {
        private int Id;
        private Estado estado;
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;


        //get y set
        public int id { get => Id; set => Id = value; }
        public DateTime FechaDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }
        public Estado Estado { get => estado; set => estado = value; }
        //CONSTRUCTOR DE LA CLASE

        public CambioEstadoTurno(Estado estado, DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            this.estado = estado;
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
        }
        public CambioEstadoTurno(Estado estado, DateTime fechaHoraDesde)
        {
            this.estado = estado;
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = DateTime.Parse("01/01/1900");
        }
        



        public CambioEstadoTurno() { }

       

        public bool esActual()  // VERIFICA QUE ES EL CAMBIO DE ESTADO ACTUAL (ES DECIR NO TIENE FECHA HASTA)
        {
            return (this.fechaHoraHasta == DateTime.Parse("01/01/1900"));
        }

        public void setFechaHoraHasta( DateTime fechaHora)  // SETEA EL VALOR DE FECHAHORAHASTA
        {
            this.fechaHoraHasta = fechaHora;
        }
    }
}
