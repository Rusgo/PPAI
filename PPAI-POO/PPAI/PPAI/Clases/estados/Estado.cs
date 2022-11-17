using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI
{
    public abstract class Estado     //DEFINO LA CLASE
    {
        private int Id;
        
        


        //CONSTRUCTOR DE LA CLASE
        public Estado() { }

        //GETTERS Y SETTERS
        public int id { get => Id; set => Id = value; }

        
        //generales(explicar)
        public abstract Estado crearProximoEstado();
        public abstract string obtenerNombre();
        public abstract void iniciarMantenimiento();

        //Metodos de estado turno
        public abstract void reservar(Turno turno, List<CambioEstadoTurno> h, DateTime date, RecursoTecnologico rt, Turno ts, PersonalCientifico cl);
        public abstract void rechazarReserva();
        public abstract void confirmarReserva();
        public abstract void cancelarReserva();
        public abstract void aular();
        public abstract void registrarNoUsado();
        public abstract void registrarUso();

        //MetodosDelEstadoRT
        public abstract void habilitar();
        public abstract void finañizarMantenimiento();
        public abstract void extenderMantenimiento();
        public abstract void registrarBajaTecnica();
        public abstract void ingresarMantenimientoCorrectivo();
        public abstract void darDeBaja();

    }
}