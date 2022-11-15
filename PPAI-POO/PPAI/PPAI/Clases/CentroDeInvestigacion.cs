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
        public int Id;
        public string nombre;
        public List<RecursoTecnologico> recursoTecnologico;
        public List<AsignacionCientificoDelCI> cientificos;

        //get y set
        public int id { get => Id; set => Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<RecursoTecnologico> RecursoTecnologico { get => recursoTecnologico; set => recursoTecnologico = value; }
        public List<AsignacionCientificoDelCI> Cientificos { get => cientificos; set => cientificos = value; }

        //CONSTRUCTOR DE LA CLASE

        public CentroDeInvestigacion(string nombre, List<RecursoTecnologico> recursoTecnologico, List<AsignacionCientificoDelCI> cientificos)
        {
            this.nombre = nombre;
            this.recursoTecnologico = recursoTecnologico.ToList();
            this.cientificos = cientificos.ToList();
        }

        public CentroDeInvestigacion() { }

       

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
            using (Contexto.Context ctx = new Contexto.Context())
            {
                foreach (RecursoTecnologico recursoTecnologico in recursoTecnologico)
                {
                    RecursoTecnologico rt1 = ctx.RecursosTecnologicos.Include("Modelo").Include("TipoRecursoTecnologico").Include("cambioEstadoActual").Where(x=>x.id == recursoTecnologico.id).FirstOrDefault();
                    if (rt1.esTuTipo(tipoRTSeleccionado))
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
