using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class Estado     //DEFINO LA CLASE
    {
        private string nombre;
        private string descripcion;
        private string ambito;
        private bool esCancelable;
        private bool esReservable;

        //CONSTRUCTOR DE LA CLASE

        public Estado(string nombre, string descripcion, string ambito, bool esCancelable, bool esReservable)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ambito = ambito;
            this.esCancelable = esCancelable;
            this.esReservable = esReservable;
        }

        public Estado() { }

        //GETTERS Y SETTERS
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Ambito { get => ambito; set => ambito = value; }
        public bool EsReservable { get => esReservable; set => esReservable = value; }


        public bool esEstadoReservable() // VERIFICA QUE EL ESTADO SEA RESERVABLE
        {
            if (esReservable)
            {
                return esReservable;
            }

            return false;
        }

        public bool esAmbitoTurno()  // VERIFICA QUE EL ESTADO ES DEL AMBITO TURNO
        {
            return (this.ambito == "turno");
        }

        public bool esReservado()  // VERIFICA QUE EL ESTADO ES RESERVADO
        {
            return (this.nombre == "Reservado");
        }

        public string getNombre() //DEVUELVE EL NOMBRE DEL ESTADO
        {
            return this.nombre;
        }
    }
}

