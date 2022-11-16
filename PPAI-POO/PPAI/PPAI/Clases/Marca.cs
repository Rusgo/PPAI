using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class Marca  //DEFINO LA CLASE 
    {
        private int Id;
        private List <Modelo> modelos;
        private string nombre;

        //CONSTRUCTOR DE LA CLASE

        public Marca(string nombre, List<Modelo> modelos)
        {
            this.modelos = modelos;
            this.nombre = nombre;
        }

        public Marca() { }

        //GETTER Y SETTER DE LA CLASE MARCA
        public int id { get => Id; set => Id = value; }
        public List<Modelo> Modelos { get => modelos; set => modelos = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string getNombre() //DEVUELVE EL NOMBRE DE LA MARCA
        {
            return nombre;
        }

        public bool esTuModelo(Modelo modelo) //VERIFICA QUE EL MODELO PERTENECE A LA MARCA
        {
            foreach (Modelo item in modelos)
            {
                if (item.id == modelo.id)
                {
                    return true;
                }
            }
            return false;   
        }
    }
}
