using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoDatos;

namespace PPAI
{
    public class Usuario        //DEFINO LA CLASE 
    {
        private int Id;
        private Boolean habilitado;
        private string clave;
        private string usuario;

        //CONSTRUCTOR DE LA CLASE

        public Usuario(Boolean habilitado, string clave, string usuario)
        {
            this.habilitado = habilitado;
            this.clave = clave;
            this.usuario = usuario;
        }

        public Usuario() { }

        //GETTERS Y SETTERS
        public int id { get => Id; set => Id = value; }
        public Boolean Habilitado { get => habilitado; set => habilitado = value; }
        public string Contraseña { get => clave; set => clave = value; }
        public string UsuarioNombre { get => usuario; set => usuario = value; }

        public PersonalCientifico getCientifico()  //OBTIENE EL PUNTERO AL CIENTIFICO
        {
            PersonalCientifico personal = null;
            foreach ( PersonalCientifico pc in ObjetosCreados.PersonalesCientifico)
            {
                if (pc.esTuUsuario(this))
                {
                    personal = pc;
                }
            }
            return personal;
        }
    }
}
