using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class Reservado:Estado
    {

        public override void reservar(Turno turno, List<CambioEstadoTurno> h, DateTime date)
        {
            throw new NotImplementedException();
        }
        public override Estado crearProximoEstado()
        {
            throw new NotImplementedException();
        }
    }
}
