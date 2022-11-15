using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoDatos;

namespace PPAI
{
    public class Modelo //DEFINO LA CLASE 
    {
        private int Id;
        private string nombre;

        //CONSTRUCTOR DE LA CLASE

        public Modelo(string nombre)
        {
            this.nombre = nombre;
        }

        public Modelo() { }

        //GET Y SET DE LA CLASE MODELO
        public int id { get => Id; set => Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public List<string> getMarcaYModelo()                     //CREA UNA LISTA CON LOS MODELOS Y MARCAS DE LOS RT
        {
            using (Contexto.Context ctx = new Contexto.Context())
            {
                List<Marca> LM = ctx.Marcas.Include("Modelos").ToList();
                List<string> modeloYMarca = new List<string>();
                string nombreMarca = "";
                foreach (Marca marca in LM)
                {
                    if (marca.esTuModelo(this))
                    {
                        nombreMarca = marca.getNombre();
                        break;
                    }
                }

                modeloYMarca.Add(nombreMarca);
                modeloYMarca.Add(nombre);

                return modeloYMarca;
            }
            

        }
    }
}
