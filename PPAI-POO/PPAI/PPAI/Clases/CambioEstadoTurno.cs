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
        private int Id { get; set; }
        private Estado estado { get; set; }
        private DateTime fechaHoraDesde { get; set; }
        private DateTime fechaHoraHasta { get; set; }

        //CONSTRUCTOR DE LA CLASE

        public CambioEstadoTurno(Estado estado, DateTime fechaHoraDesde, [Optional] DateTime fechaHoraHasta)
        {
            this.estado = estado;
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
        }

        public CambioEstadoTurno() { }

       

        public bool esActual()  // VERIFICA QUE ES EL CAMBIO DE ESTADO ACTUAL (ES DECIR NO TIENE FECHA HASTA)
        {
            return (this.fechaHoraHasta == DateTime.MinValue);
        }

        public string getEstado() // DEVUELVE EL NOMBRE DEL ESTADO
        {
            return this.estado.getNombre();
        }

        public void setFechaHoraHasta( DateTime fechaHora)  // SETEA EL VALOR DE FECHAHORAHASTA
        {
            this.fechaHoraHasta = fechaHora;
        }
    }
}
