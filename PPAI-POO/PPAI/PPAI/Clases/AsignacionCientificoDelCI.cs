using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoDatos;
using PPAI.Forms;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Entity;

namespace PPAI
{
    public class AsignacionCientificoDelCI //DEFINO LA CLASE 
    {
        private int Id;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private List<Turno> turnos;
        private PersonalCientifico personalCientifico;


        //GET Y SET
        public int id { get => Id; set => Id = value; }
        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public List<Turno> Turnos { get => turnos; set => turnos = value; }
        public PersonalCientifico PersonalCientifico { get => personalCientifico; set => personalCientifico = value; }
        

        //CONSTRUCTOR DE LA CLASE

        public AsignacionCientificoDelCI(DateTime fechaDesde, PersonalCientifico personalCientifico, List<Turno> turnos, [Optional] DateTime fechaHasta) 
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.personalCientifico = personalCientifico;
            this.turnos = turnos;
        }

        public AsignacionCientificoDelCI(DateTime fechaDesde, PersonalCientifico personalCientifico, [Optional] DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.personalCientifico = personalCientifico;
        }

        public AsignacionCientificoDelCI() { }


        public bool esActivo()      //VERIFICA QUE LA ASIGNACION ES ACTIVA (SI NO TIENE FECHA HASTA)
        {
            return (this.fechaHasta == DateTime.MinValue);
        }

        public bool esTuCientifico(PersonalCientifico cientificoLogueado)      //VERIFICA QUE ES EL CIENTIFICO ENVIADO POR PARAMETRO
        {
            
            return (this.personalCientifico == cientificoLogueado);
        }

        public void asignarTurno(Turno turno)  //ASIGNA EL TURNO ENVIADO POR PARAMETRO A LA ASIGNACION
        {
            if (turnos == null)
            {
                turnos = new List<Turno>();
                this.turnos.Add(turno);
                
            }
            else
            {
                this.turnos.Add(turno);
            }
            
        }
    }


}
