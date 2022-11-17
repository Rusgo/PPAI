using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.Clases;

namespace PPAI.Clases
{
    public class Disponible:Estado
    {
        public override void reservar(Turno turno, List<CambioEstadoTurno> h, DateTime date, RecursoTecnologico rt,Turno ts, PersonalCientifico cl)
        {

            //definir fecha hasta al ultimo ce
            esActual(h, date);
            //crear proximo Estado
            Estado estado = crearProximoEstado();
            //crear nuevo CE Turno
            CambioEstadoTurno ce =  crearProximoCE(date, estado);
            //Asignar Cientifico que forma parte de la reserva
            CentroDeInvestigacion ci = getCI(rt);
            ci.asignarTurno(ts, cl);
            //Agrega CE
            turno.agregarCE(ce);
            //Settear nuevo Estado
            turno.EstadoActual = estado;

        }

        public void esActual(List<CambioEstadoTurno> h, DateTime date)
        {
            foreach (CambioEstadoTurno ce in h)
            {
                if (ce.esActual())
                {
                    ce.FechaHasta = date;
                    break;
                }
            }
        }
        public CentroDeInvestigacion getCI(RecursoTecnologico recursoTecnologico)
        {
            using (Contexto.Context ctx = new Contexto.Context())
            {
                List<CentroDeInvestigacion> lista = ctx.CentroDeInvestigacion.Include("recursoTecnologico").Include("cientificos").ToList();
                foreach (CentroDeInvestigacion ci in lista)
                {
                    if (ci.esTuRecurso(recursoTecnologico))
                    {
                        return ci;
                    }

                }
                return null;
            }

        }
        public override Estado crearProximoEstado()
        {
            Reservado reservado = new Reservado();
            return reservado;
        }
        public  CambioEstadoTurno crearProximoCE(DateTime date, Estado estado)
        {
            CambioEstadoTurno CE = new CambioEstadoTurno(estado,date);
            return CE;
        }

        public override string obtenerNombre()
        {
            return "Disponible";
        }

        public override void iniciarMantenimiento()
        {
            throw new NotImplementedException();
        }

        public override void rechazarReserva()
        {
            throw new NotImplementedException();
        }

        public override void confirmarReserva()
        {
            throw new NotImplementedException();
        }

        public override void cancelarReserva()
        {
            throw new NotImplementedException();
        }

        public override void aular()
        {
            throw new NotImplementedException();
        }

        public override void registrarNoUsado()
        {
            throw new NotImplementedException();
        }

        public override void registrarUso()
        {
            throw new NotImplementedException();
        }

        public override void habilitar()
        {
            throw new NotImplementedException();
        }

        public override void finañizarMantenimiento()
        {
            throw new NotImplementedException();
        }

        public override void extenderMantenimiento()
        {
            throw new NotImplementedException();
        }

        public override void registrarBajaTecnica()
        {
            throw new NotImplementedException();
        }

        public override void ingresarMantenimientoCorrectivo()
        {
            throw new NotImplementedException();
        }

        public override void darDeBaja()
        {
            throw new NotImplementedException();
        }
    }
}
