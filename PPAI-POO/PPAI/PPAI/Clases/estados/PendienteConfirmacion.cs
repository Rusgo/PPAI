using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    internal class PendienteConfirmacion : Estado
    {
        public override Estado crearProximoEstado()
        {
            throw new NotImplementedException();
        }

        public override string obtenerNombre()
        {
            return "Con reserva pendiente de confirmacion";
        }

        public override void reservar(Turno turno, List<CambioEstadoTurno> h, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
