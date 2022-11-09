using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PPAI
{
    public class CambioEstadoRT     //DEFINO LA CLASE
    {
        private int Id { get; set; }
        private Estado estado { get; set; }
        private DateTime fechaHoraDesde { get; set; }
        private DateTime fechaHoraHasta { get; set; }

        //CONSTRUCTOR DE LA CLASE
        public CambioEstadoRT(Estado estado, DateTime fechaHoraDesde, [Optional] DateTime fechaHoraHasta)
        {
            this.estado = estado;
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
        }

        public CambioEstadoRT() { }

       

        public bool esActual() // VERIFICA QUE ES EL CAMBIO DE ESTADO ACTUAL (ES DECIR NO TIENE FECHA HASTA)
        {
            return (this.fechaHoraHasta == DateTime.MinValue);
        }

        public bool esEstadoActualReservable() // VERIFICA QUE EL ESTADO ACTUAL SEA RESERVABLE
        {
            return estado.esEstadoReservable();
        }
        
        public string getEstado() // DEVUELVE EL NOMBRE DEL ESTADO
        {
            return estado.getNombre();
        }
    }
}

