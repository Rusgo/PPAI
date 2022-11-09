using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoDatos;

namespace PPAI
{
    public class CentroDeInvestigacion      //DEFINO LA CLASE
    {
        private string nombre;
        private List<RecursoTecnologico> recursoTecnologico;
        private List<AsignacionCientificoDelCI> cientificos;

        //CONSTRUCTOR DE LA CLASE

        public CentroDeInvestigacion(string nombre, List<RecursoTecnologico> recursoTecnologico, List<AsignacionCientificoDelCI> cientificos)
        {
            this.nombre = nombre;
            this.recursoTecnologico = recursoTecnologico;
            this.cientificos = cientificos;
        }

        public CentroDeInvestigacion() { }

        //GETTERS Y SETTERS
        public string Nombre { get => nombre; set => nombre = value; }
        public List<RecursoTecnologico> RecursoTecnologico { get => recursoTecnologico; set => recursoTecnologico = value; }
        public List<AsignacionCientificoDelCI> Cientificos { get => cientificos; set => cientificos = value; }

        public string getNombre() // DEVUELVE EL NOMBRE DEL CI
        {
            return this.nombre;
        }

        public  bool esTuRecurso( RecursoTecnologico rt) // VERIFICA QUE EL RT PERTENECE AL CI
        {
            return recursoTecnologico.Contains(rt);
        }

        public List<List<string>> tieneRTDelTipoRTSeleccionado(TipoRecursoTecnologico tipoRTSeleccionado, List<List<string>> s) //BUSCA SOBRE SUS RT LOS QUE CORRESPONDEN AL TIPORTSELECCIONADO Y SEAN ACTIVOS
        {
            foreach (RecursoTecnologico recursoTecnologico in recursoTecnologico)
            {
                if (recursoTecnologico.esTuTipo(tipoRTSeleccionado))
                {
                    if (recursoTecnologico.esActivo())
                    {
                        List<string> datos = new List<string>();
                        datos.Add(this.nombre);
                        foreach (string datosrt in recursoTecnologico.getDatos(recursoTecnologico))
                        {
                            datos.Add(datosrt);
                        }
                        s.Add(datos);
                    }
                }
            }
            return s;
        }

        public bool esCientificoActivo( PersonalCientifico cientificoLogueado)           //VERIFICA SI LA ASIGNACION DEL CIENTIFICO ES ACTIVA
        {
            foreach (AsignacionCientificoDelCI asignacion in ObjetosCreados.Asignaciones)
            {
                if (asignacion.esActivo())
                {
                    return (asignacion.esTuCientifico(cientificoLogueado));
                }
                
            }
            return false;

        }

        public void asignarTurno(Turno turno, PersonalCientifico cientificoLogueado)        //ASIGNA EL TURNO A LA ASIGNACION DEL CIENTIFICO LOGUEADO
        {
            foreach (AsignacionCientificoDelCI asignacion in this.Cientificos)
            {
                if(asignacion.PersonalCientifico == cientificoLogueado)
                {
                    asignacion.asignarTurno(turno);
                }
            }
        }
    }

    
}
