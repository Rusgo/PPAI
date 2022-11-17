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
        private int Id;
        private Estado estado;
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;


        //get y set
        public int id { get => Id; set => Id = value; }
        public DateTime FechaDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }
        public Estado Estado{ get => estado; set => estado = value; }
        
        //CONSTRUCTOR DE LA CLASE
        public CambioEstadoRT(Estado estado, DateTime fechaHoraDesde, [Optional] DateTime fechaHoraHasta)
        {
            this.estado = estado;
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
        }
        
        public CambioEstadoRT(Estado estado, DateTime fechaHoraDesde)
        {
            this.estado = estado;
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = DateTime.Parse("01/01/1900");
        }


        public CambioEstadoRT() { }

       

        public bool esActual() // VERIFICA QUE ES EL CAMBIO DE ESTADO ACTUAL (ES DECIR NO TIENE FECHA HASTA)
        {
            return (this.fechaHoraHasta == DateTime.MinValue);
        }

        public bool esEstadoActualReservable() // VERIFICA QUE EL ESTADO ACTUAL SEA RESERVABLE
        {
            return false;
        }
        
        
    }
}

