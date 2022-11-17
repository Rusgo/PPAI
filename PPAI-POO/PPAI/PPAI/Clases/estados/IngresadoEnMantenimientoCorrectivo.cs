using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class IngresadoEnMantenimientoCorrectivo : Estado
    {
        public override void aular()
        {
            throw new NotImplementedException();
        }

        public override void cancelarReserva()
        {
            throw new NotImplementedException();
        }

        public override void confirmarReserva()
        {
            throw new NotImplementedException();
        }

        public override Estado crearProximoEstado()
        {
            throw new NotImplementedException();
        }

        public override void darDeBaja()
        {
            throw new NotImplementedException();
        }

        public override void extenderMantenimiento()
        {
            throw new NotImplementedException();
        }

        public override void finañizarMantenimiento()
        {
            throw new NotImplementedException();
        }

        public override void habilitar()
        {
            throw new NotImplementedException();
        }

        public override void ingresarMantenimientoCorrectivo()
        {
            throw new NotImplementedException();
        }

        public override void iniciarMantenimiento()
        {
            throw new NotImplementedException();
        }

        public override string obtenerNombre()
        {
            return "Con inicio de Mantenimiento correctivo"; 
        }

        public override void rechazarReserva()
        {
            throw new NotImplementedException();
        }

        public override void registrarBajaTecnica()
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

        public override void reservar(Turno turno, List<CambioEstadoTurno> h, DateTime date, RecursoTecnologico rt, Turno ts, PersonalCientifico cl)
        {
            throw new NotImplementedException();
        }
    }
}
