using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class Reservado:Estado
    {

        
        public override Estado crearProximoEstado()
        {
            throw new NotImplementedException();
        }

        public override string obtenerNombre()
        {
            return "Reservado";
        }

        public override void reservar(Turno turno, List<CambioEstadoTurno> h, DateTime date, RecursoTecnologico rt, Turno ts, PersonalCientifico cl)
        {
            throw new NotImplementedException();
        }
    }
}
