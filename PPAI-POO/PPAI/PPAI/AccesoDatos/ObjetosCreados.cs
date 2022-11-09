﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI;
using System.Globalization;

namespace PPAI.AccesoDatos
{
    public class ObjetosCreados
    {

        public static Usuario usuarioActual = new Usuario(true, "123", "PPAI"); //usuario
        public static Usuario usuario2 = new Usuario(true, "456", "MariaC"); //usuario
        public static List<Usuario> Usuarios = new List<Usuario> { usuarioActual, usuario2 };

        public static Sesion sesionActual = new Sesion(DateTime.Now, usuarioActual);


        //tipos de recurso
        public static TipoRecursoTecnologico tipoRT1 = new TipoRecursoTecnologico("Balanza de precisión", "");
        public static TipoRecursoTecnologico tipoRT2 = new TipoRecursoTecnologico("Microscopio", "");
        public static TipoRecursoTecnologico tipoRT3 = new TipoRecursoTecnologico("Resonador magnético", "");
        public static TipoRecursoTecnologico tipoRT4 = new TipoRecursoTecnologico("Equipamiento de cómputo de datos de alto rendimiento", "");

        public static List<TipoRecursoTecnologico> TiposRT = new List<TipoRecursoTecnologico> { tipoRT1, tipoRT2, tipoRT3, tipoRT4 };



        //modelos
        public static Modelo modelo1 = new Modelo("TXB622L");
        public static Modelo modelo2 = new Modelo("TXB622M");
        public static Modelo modelo3 = new Modelo("TXB622N");

        public static Modelo modelo4 = new Modelo("ABC123");
        public static Modelo modelo5 = new Modelo("ABC456");
        public static Modelo modelo6 = new Modelo("ABC789");

        public static Modelo modelo7 = new Modelo("DSI123");
        public static Modelo modelo8 = new Modelo("DSI456");
        public static Modelo modelo9 = new Modelo("DSI789");

        public static Modelo modelo10 = new Modelo("PPAI123");
        public static Modelo modelo11 = new Modelo("PPAI456");
        public static Modelo modelo12 = new Modelo("PPAI789");

        public static List<Modelo> Modelos = new List<Modelo> { modelo1, modelo2, modelo3, modelo4, modelo5, modelo6, modelo7, modelo8, modelo9, modelo10, modelo11, modelo12 };

        public static List<Modelo> listaModelosMarca1 = new List<Modelo> { modelo1, modelo2, modelo3 };
        public static List<Modelo> listaModelosMarca2 = new List<Modelo> { modelo4, modelo5, modelo6 };
        public static List<Modelo> listaModelosMarca3 = new List<Modelo> { modelo7, modelo8, modelo9 };
        public static List<Modelo> listaModelosMarca4 = new List<Modelo> { modelo10, modelo11, modelo12 };

        //marcas
        public static Marca marca1 = new Marca("Shidmazu", listaModelosMarca1);
        public static Marca marca2 = new Marca("Marolio", listaModelosMarca2);
        public static Marca marca3 = new Marca("IBM", listaModelosMarca3);
        public static Marca marca4 = new Marca("Microsoft", listaModelosMarca4);
        public static List<Marca> Marcas = new List<Marca> { marca1, marca2, marca3, marca4 };



        //estados turno
        public static Estado estado1 = new Estado("Cancelado por mantenimiento correctivo", "Estado de turno cancelado por mantenimiento correctivo", "turno", false, false);
        public static Estado estado2 = new Estado("Con ingreso en Mantenimiento correctivo", "Estado de turno con ingreso en Mantenimiento correctivo", "turno", false, false);
        public static Estado estado3 = new Estado("Disponible", "Estado de turno Disponible", "turno", true, true);
        public static Estado estado4 = new Estado("Reservado", "Estado de turno Reservado", "turno", true, false);
        public static Estado estado5 = new Estado("Sin Uso", "Estado de turno Sin Uso", "turno", false, false);
        public static Estado estado6 = new Estado("En Uso", "Estado de turno En Uso", "turno", false, false);
        public static Estado estado7 = new Estado("Reserva Sin Uso", "Estado de turno Reserva Sin Uso", "turno", false, false);
        public static Estado estado8 = new Estado("Con reserva pendiente de confirmacion", "Estado de turno Con reserva pendiente de confirmacion", "turno", true, false);

        //estados rt
        public static Estado estado9 = new Estado("Ingresado", "Estado de RT Disponible", "rt", false, false);
        public static Estado estado10 = new Estado("Disponible", "Estado de RT Disponible", "rt", false, true);
        public static Estado estado11 = new Estado("En mantenimiento", "Estado de RT En mantenimiento", "rt", false, true);
        public static Estado estado12 = new Estado("Con inicio de Mantenimiento correctivo", "Estado de RT En mantenimiento", "rt", false, true);
        public static Estado estado13 = new Estado("Dado de baja técnica", "Estado de RT En mantenimiento", "rt", false, false);
        public static Estado estado14 = new Estado("Dado de baja definitiva", "Estado de RT En mantenimiento", "rt", false, false);

        public static List<Estado> Estados = new List<Estado> { estado1, estado2, estado3, estado4, estado5, estado6, estado7, estado8, estado9, estado10, estado11, estado12, estado13, estado14 };


        //cambios de estado rt
        public static CambioEstadoRT cambioEstado1RT1 = new CambioEstadoRT(estado9, DateTime.Parse("05/05/2022"), DateTime.Parse("08/05/2022"));
        public static CambioEstadoRT cambioEstado2RT1 = new CambioEstadoRT(estado10, DateTime.Parse("05/05/2022"));


        public static CambioEstadoRT cambioEstado1RT2 = new CambioEstadoRT(estado9, DateTime.Parse("04/05/2022"), DateTime.Parse("07/05/2022"));
        public static CambioEstadoRT cambioEstado2RT2 = new CambioEstadoRT(estado11, DateTime.Parse("05/05/2022"));

        public static CambioEstadoRT cambioEstado1RT3 = new CambioEstadoRT(estado9, DateTime.Parse("04/05/2022"), DateTime.Parse("07/05/2022"));
        public static CambioEstadoRT cambioEstado2RT3 = new CambioEstadoRT(estado12, DateTime.Parse("05/05/2022"));

        public static CambioEstadoRT cambioEstado1RT4 = new CambioEstadoRT(estado9, DateTime.Parse("04/05/2022"), DateTime.Parse("07/05/2022"));
        public static CambioEstadoRT cambioEstado2RT4 = new CambioEstadoRT(estado12, DateTime.Parse("05/05/2022"));

        public static CambioEstadoRT cambioEstado1RT5 = new CambioEstadoRT(estado9, DateTime.Parse("04/05/2022"), DateTime.Parse("07/05/2022"));
        public static CambioEstadoRT cambioEstado2RT5 = new CambioEstadoRT(estado12, DateTime.Parse("05/05/2022"));

        public static List<CambioEstadoRT> CambiosEstadoRT = new List<CambioEstadoRT> { cambioEstado1RT1, cambioEstado2RT1, cambioEstado1RT2, cambioEstado2RT2, cambioEstado1RT3, cambioEstado2RT3, cambioEstado1RT4, cambioEstado2RT4, cambioEstado1RT5, cambioEstado2RT5 };

        public static List<CambioEstadoRT> listaCambioEstadoRT1 = new List<CambioEstadoRT> { cambioEstado1RT1, cambioEstado2RT1 };
        public static List<CambioEstadoRT> listaCambioEstadoRT2 = new List<CambioEstadoRT> { cambioEstado1RT2, cambioEstado2RT2 };
        public static List<CambioEstadoRT> listaCambioEstadoRT3 = new List<CambioEstadoRT> { cambioEstado1RT3, cambioEstado2RT3 };
        public static List<CambioEstadoRT> listaCambioEstadoRT4 = new List<CambioEstadoRT> { cambioEstado1RT4, cambioEstado2RT4 };
        public static List<CambioEstadoRT> listaCambioEstadoRT5 = new List<CambioEstadoRT> { cambioEstado1RT5, cambioEstado2RT5 };


        //personal cientifico
        public static PersonalCientifico personalCientifico1 = new PersonalCientifico("83184", "Ramon", "Flores", 43232681, 351234567, "ramonflores@un.edu.ar", "ramonflores@hotmail.com", usuarioActual);
        public static PersonalCientifico personalCientifico2 = new PersonalCientifico("84777", "Maria", "Curie", 45594674, 351234321, "mariacurie@un.edu.ar", "ramonflores@hotmail.com", usuario2);

        public static List<PersonalCientifico> PersonalesCientifico = new List<PersonalCientifico> { personalCientifico1, personalCientifico2 };


        //cambios de estado turno
        public static CambioEstadoTurno cambioEstado1turno1 = new CambioEstadoTurno(estado6, DateTime.Parse("05/05/2022"), DateTime.Parse("08/05/2022"));
        public static CambioEstadoTurno cambioEstado2turno1 = new CambioEstadoTurno(estado3, DateTime.Parse("05/05/2022"));


        public static CambioEstadoTurno cambioEstado1turno2 = new CambioEstadoTurno(estado6, DateTime.Parse("04/05/2022"), DateTime.Parse("04/05/2022"));
        public static CambioEstadoTurno cambioEstado2turno2 = new CambioEstadoTurno(estado8, DateTime.Parse("05/05/2022"));

        public static CambioEstadoTurno cambioEstado1turno3 = new CambioEstadoTurno(estado6, DateTime.Parse("04/05/2022"), DateTime.Parse("07/05/2022"));
        public static CambioEstadoTurno cambioEstado2turno3 = new CambioEstadoTurno(estado4, DateTime.Parse("05/05/2022"));

        public static CambioEstadoTurno cambioEstado1turno4 = new CambioEstadoTurno(estado6, DateTime.Parse("04/05/2022"), DateTime.Parse("04/05/2022"));
        public static CambioEstadoTurno cambioEstado2turno4 = new CambioEstadoTurno(estado8, DateTime.Parse("05/05/2022"));

        public static CambioEstadoTurno cambioEstado1turno5 = new CambioEstadoTurno(estado6, DateTime.Parse("04/05/2022"), DateTime.Parse("07/05/2022"));
        public static CambioEstadoTurno cambioEstado2turno5 = new CambioEstadoTurno(estado4, DateTime.Parse("05/05/2022"));

        public static List<CambioEstadoTurno> CambiosEstadoTurnos = new List<CambioEstadoTurno> { cambioEstado1turno1, cambioEstado2turno1, cambioEstado1turno2, cambioEstado2turno2, cambioEstado1turno3, cambioEstado2turno3, cambioEstado1turno4, cambioEstado2turno4, cambioEstado1turno5, cambioEstado2turno5 };

        public static List<CambioEstadoTurno> listaCambioEstadoTurno1 = new List<CambioEstadoTurno> { cambioEstado1turno1, cambioEstado2turno1 };
        public static List<CambioEstadoTurno> listaCambioEstadoTurno2 = new List<CambioEstadoTurno> { cambioEstado1turno2, cambioEstado2turno2 };
        public static List<CambioEstadoTurno> listaCambioEstadoTurno3 = new List<CambioEstadoTurno> { cambioEstado1turno3, cambioEstado2turno3 };
        public static List<CambioEstadoTurno> listaCambioEstadoTurno4 = new List<CambioEstadoTurno> { cambioEstado1turno4, cambioEstado2turno4 };
        public static List<CambioEstadoTurno> listaCambioEstadoTurno5 = new List<CambioEstadoTurno> { cambioEstado1turno5, cambioEstado2turno5 };

        //turnos                                                                                                                                             
        public static Turno turno1 = new Turno(DateTime.Parse("05/05/2022"), "Lunes", DateTime.Parse("04 / 07 / 2022 08:30"), DateTime.Parse("04 / 07 / 2022 09:30"), listaCambioEstadoTurno1);
        public static Turno turno2 = new Turno(DateTime.Parse("05/05/2022"), "Martes", DateTime.Parse("05 / 07 / 2022 08:30"), DateTime.Parse("05 / 07 / 2022 09:30"), listaCambioEstadoTurno2);
        public static Turno turno3 = new Turno(DateTime.Parse("05/05/2022"), "Miercoles", DateTime.Parse("06 / 07 / 2022 11:30"), DateTime.Parse("06 / 07 / 2022 14:30"), listaCambioEstadoTurno3);
        public static Turno turno4 = new Turno(DateTime.Parse("05/05/2022"), "Jueves", DateTime.Parse("07 / 07 / 2022 08:30"), DateTime.Parse("07 / 07 / 2022 09:30"), listaCambioEstadoTurno1);
        public static Turno turno5 = new Turno(DateTime.Parse("05/05/2022"), "Viernes", DateTime.Parse("08 / 07 / 2022 18:30"), DateTime.Parse("08 / 07 / 2022 20:30"), listaCambioEstadoTurno2);
        public static Turno turno6 = new Turno(DateTime.Parse("05/05/2022"), "Lunes", DateTime.Parse("11 / 07 / 2022 08:30"), DateTime.Parse("11 / 07 / 2022 09:30"), listaCambioEstadoTurno3);
        public static Turno turno7 = new Turno(DateTime.Parse("05/05/2022"), "Martes", DateTime.Parse("04 / 07 / 2022 10:30"), DateTime.Parse("04 / 07 / 2022 11:30"), listaCambioEstadoTurno2);
        public static Turno turno8 = new Turno(DateTime.Parse("05/05/2022"), "Miercoles", DateTime.Parse("04 / 07 / 2022 12:30"), DateTime.Parse("04 / 07 / 2022 13:30"), listaCambioEstadoTurno3);
        public static Turno turno9 = new Turno(DateTime.Parse("05/05/2022"), "Jueves", DateTime.Parse("08 / 07 / 2022 08:30"), DateTime.Parse("08 / 07 / 2022 09:30"), listaCambioEstadoTurno4);
        public static Turno turno10 = new Turno(DateTime.Parse("05/05/2022"), "Viernes", DateTime.Parse("14 / 07 / 2022 14:30"), DateTime.Parse("14 / 07 / 2022 16:30"), listaCambioEstadoTurno5);
        public static Turno turno11 = new Turno(DateTime.Parse("05/05/2022"), "Lunes", DateTime.Parse("26 / 07 / 2022 13:30"), DateTime.Parse("26 / 07 / 2022 15:30"), listaCambioEstadoTurno4);
        public static Turno turno12 = new Turno(DateTime.Parse("05/05/2022"), "Martes", DateTime.Parse("09 / 07 / 2022 17:30"), DateTime.Parse("09 / 07 / 2022 19:30"), listaCambioEstadoTurno5);

        public static List<Turno> Turnos = new List<Turno> { turno1, turno2, turno3, turno4, turno5, turno6, turno7, turno8, turno9, turno10, turno11, turno12 };
        public static List<Turno> turnosAsignacion1 = new List<Turno> { turno1, turno2, turno3 };
        public static List<Turno> turnosAsignacion2 = new List<Turno> { turno4, turno5, turno6 };
        public static List<Turno> turnosAsignacion3 = new List<Turno> { turno1, turno2, turno3 };
        public static List<Turno> turnosAsignacion4 = new List<Turno> { turno4, turno5, turno6 };
        public static List<Turno> turnosAsignacion5 = new List<Turno> { turno7, turno8, turno9 };
        public static List<Turno> turnosAsignacion6 = new List<Turno> { turno10, turno11, turno12 };


        //recursos tecnologicos
        public static RecursoTecnologico RT1 = new RecursoTecnologico(100, tipoRT1, modelo1, listaCambioEstadoRT1, Turnos);
        public static RecursoTecnologico RT2 = new RecursoTecnologico(101, tipoRT2, modelo2, listaCambioEstadoRT2, Turnos);
        public static RecursoTecnologico RT3 = new RecursoTecnologico(102, tipoRT3, modelo3, listaCambioEstadoRT3, Turnos);
        public static RecursoTecnologico RT4 = new RecursoTecnologico(103, tipoRT4, modelo4, listaCambioEstadoRT1, Turnos);
        public static RecursoTecnologico RT5 = new RecursoTecnologico(104, tipoRT1, modelo5, listaCambioEstadoRT2, Turnos);
        public static RecursoTecnologico RT6 = new RecursoTecnologico(105, tipoRT2, modelo6, listaCambioEstadoRT3, Turnos);
        public static RecursoTecnologico RT7 = new RecursoTecnologico(104, tipoRT3, modelo7, listaCambioEstadoRT4, Turnos);
        public static RecursoTecnologico RT8 = new RecursoTecnologico(105, tipoRT4, modelo8, listaCambioEstadoRT5, Turnos);
        public static RecursoTecnologico RT9 = new RecursoTecnologico(104, tipoRT1, modelo9, listaCambioEstadoRT4, Turnos);
        public static RecursoTecnologico RT10 = new RecursoTecnologico(105, tipoRT2, modelo10, listaCambioEstadoRT5, Turnos);
        public static RecursoTecnologico RT11 = new RecursoTecnologico(104, tipoRT3, modelo11, listaCambioEstadoRT4, Turnos);
        public static RecursoTecnologico RT12 = new RecursoTecnologico(105, tipoRT4, modelo12, listaCambioEstadoRT5, Turnos);

        public static List<RecursoTecnologico> Recursos = new List<RecursoTecnologico> { RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12 };

        public static List<RecursoTecnologico> RecursosCI1 = new List<RecursoTecnologico> { RT1, RT2, RT3 };
        public static List<RecursoTecnologico> RecursosCI2 = new List<RecursoTecnologico> { RT4, RT5, RT6 };
        public static List<RecursoTecnologico> RecursosCI3 = new List<RecursoTecnologico> { RT7, RT8, RT9 };
        public static List<RecursoTecnologico> RecursosCI4 = new List<RecursoTecnologico> { RT10, RT11, RT12 };

        //asignacion cientificos
        public static AsignacionCientificoDelCI asignCient1 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico1, turnosAsignacion1, DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient2 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico2, turnosAsignacion2, DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient3 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico1, turnosAsignacion3, DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient4 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico2, turnosAsignacion4, DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient5 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico1, turnosAsignacion5, DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient6 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico2, turnosAsignacion6, DateTime.Parse("01/01/2025"));

        public static List<AsignacionCientificoDelCI> Asignaciones = new List<AsignacionCientificoDelCI> { asignCient1, asignCient2, asignCient3, asignCient4, asignCient5, asignCient6 };

        public static List<AsignacionCientificoDelCI> listaAsignacionCientifico1 = new List<AsignacionCientificoDelCI> { asignCient1, asignCient2 };
        public static List<AsignacionCientificoDelCI> listaAsignacionCientifico2 = new List<AsignacionCientificoDelCI> { asignCient3 };
        public static List<AsignacionCientificoDelCI> listaAsignacionCientifico3 = new List<AsignacionCientificoDelCI> { asignCient4, asignCient5 };
        public static List<AsignacionCientificoDelCI> listaAsignacionCientifico4 = new List<AsignacionCientificoDelCI> { asignCient6 };

        //centro de investigacion
        public static CentroDeInvestigacion CI1 = new CentroDeInvestigacion("Centro de Investigaciones Autónomo", RecursosCI1, listaAsignacionCientifico1);
        public static CentroDeInvestigacion CI2 = new CentroDeInvestigacion("CIDS", RecursosCI2, listaAsignacionCientifico2);
        public static CentroDeInvestigacion CI3 = new CentroDeInvestigacion("CCT", RecursosCI3, listaAsignacionCientifico3);
        public static CentroDeInvestigacion CI4 = new CentroDeInvestigacion("CONICET", RecursosCI4, listaAsignacionCientifico4);

        public static List<CentroDeInvestigacion> CentrosInvestigacion = new List<CentroDeInvestigacion> { CI1, CI2, CI3, CI4 };


        //interfaz

        public static InterfazMail InterfazMail = new InterfazMail();
        public static InterfazWhatsApp InterfazWhatsApp = new InterfazWhatsApp();

    }
}