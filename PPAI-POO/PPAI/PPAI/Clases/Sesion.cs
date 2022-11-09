using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace PPAI
{
        public class Sesion         //DEFINO LA CLASE 
    {
            private int idSesion;
            private DateTime fechaHoraInicio;
            private DateTime fechaHoraFin;
            private Usuario usuario;

        //CONSTRUCTOR DE LA CLASE

            public Sesion(DateTime fechaHoraInicio, Usuario usuario, [Optional] DateTime fechaHoraFin)
            {
                this.fechaHoraInicio = fechaHoraInicio;
                this.fechaHoraFin = fechaHoraFin;
                this.usuario = usuario;
            }

            public Sesion() { }

            //GETTERS Y SETTERS
            public int IdSesion { get => idSesion; set => idSesion = value; }
            public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
            public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
            internal Usuario Usuario { get => usuario; set => usuario = value; }

            public PersonalCientifico getCientifico()   //LE PIDE AL USUARIO QUE OBTENGA SU CIENTIFICO ASOCIADO
            {
                return usuario.getCientifico();

            }
        }
}

