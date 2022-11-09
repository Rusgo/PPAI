using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{
    public class TipoRecursoTecnologico     //DEFINO LA CLASE 
    {
        private int Id;
        private string nombre;
        private string descripcion;

        //CONSTRUCTOR DE LA CLASE

        public TipoRecursoTecnologico(string nombre, string descripcion)
        {

            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public TipoRecursoTecnologico() { }

        //GETTERS Y SETTERS
        public int id { get => Id; set => Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public string getNombre()  //DEVUELVE EL NOMBRE DEL TIPO RT
        {
            return nombre;
        }

        public bool sosTipoRT(string nombreTipoRT)                    //RESPONDE SI ES DEL TIPO PASADO COMO PARAMETRO
        {
            bool resultado = false;
            if (nombreTipoRT == this.getNombre())
            {
                resultado = true;
            }
            return resultado;
        }

    }
}
