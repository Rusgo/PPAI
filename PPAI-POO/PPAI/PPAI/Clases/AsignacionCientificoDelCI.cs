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


namespace PPAI
{
    public class AsignacionCientificoDelCI //DEFINO LA CLASE 
    {
        private int Id { get; set; }
        private DateTime fechaDesde { get; set }
        private DateTime fechaHasta { get; set; }
        private PersonalCientifico personalCientifico { get; set; }
        private List<Turno> turnos { get; set; }

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
            this.turnos.Add(turno);
        }
    }


}
