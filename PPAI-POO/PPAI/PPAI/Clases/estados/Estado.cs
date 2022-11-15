using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public abstract class Estado     //DEFINO LA CLASE
    {
        private int Id;
        private string nombre;
        private string descripcion;
        


        //CONSTRUCTOR DE LA CLASE

        public Estado(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public Estado() { }

        //GETTERS Y SETTERS
        public int id { get => Id; set => Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }




        public bool esAmbitoTurno()  // VERIFICA QUE EL ESTADO ES DEL AMBITO TURNO
        {
            return false;
        }

        public bool esReservado()  // VERIFICA QUE EL ESTADO ES RESERVADO
        {
            return false;
        }

        public string getNombre() //DEVUELVE EL NOMBRE DEL ESTADO
        {
            return this.nombre;
        }

        //metodos de estado Turno
        public abstract void reservar(Turno turno, List<CambioEstadoTurno> h, DateTime date);
        public abstract Estado crearProximoEstado();

    }
}