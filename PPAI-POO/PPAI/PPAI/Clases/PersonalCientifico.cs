using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public class PersonalCientifico //DEFINO LA CLASE 
    {
        private int Id;
        private string legajo;
        private string nombre;
        private string apellido;
        private int nroDoc;
        private int telefono;
        private string correoInstitucional;
        private string correoPersonal;
        private Usuario usuario;

        //CONSTRUCTOR DE LA CLASE

        public PersonalCientifico(string legajo, string nombre, string apellido, int nroDoc, int telefono, string correoInstitucional, string correoPersonal, Usuario usuario)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nroDoc = nroDoc;
            this.telefono = telefono;
            this.correoInstitucional = correoInstitucional;
            this.correoPersonal = correoPersonal;
            this.usuario = usuario;
        }

        public PersonalCientifico() { }

        //GETTERS Y SETTERS 
        public int id { get => Id; set => Id = value; }
        public string Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => legajo = value; }
        public string Apellido { get => apellido; set => legajo = value; }
        public int NroDoc { get => nroDoc; set => nroDoc = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string CorreoInstitucional { get => correoInstitucional; set => correoInstitucional = value; }
        public string CorreoPersonal { get => correoPersonal; set => correoPersonal = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public bool esTuUsuario(Usuario usuario)
        {
            return Usuario.UsuarioNombre == usuario.UsuarioNombre;
        }

        public string getMail()     //DEVUELVE EL MAIL INSTITUCIONAL DEL CIENTIFICO
        {
            return this.CorreoInstitucional;
        }

        public int getNumeroTelefono()      //DEVUELVE EL NUMERO DE TELEFONO DEL CIENTIFICO
        {
            return this.Telefono;
        }
    }
}
