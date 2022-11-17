using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI;
using System.Globalization;
using PPAI.Clases;


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
        public static Disponible estado1 = new Disponible();
        public static Disponible estado2 = new Disponible();
        public static Disponible estado3 = new Disponible();
        public static Reservado estado4 = new Reservado();
        public static EnMantenimiento estado5 = new EnMantenimiento();
        public static IngresadoEnMantenimientoCorrectivo estado6 = new IngresadoEnMantenimientoCorrectivo();
        public static Disponible estado7 = new Disponible();
        public static Disponible estado8 = new Disponible();
        public static Disponible estado9 = new Disponible();

        public static Disponible estado10 = new Disponible();
        public static Disponible estado11 = new Disponible();
        public static Disponible estado12 = new Disponible();
        public static Disponible estado13 = new Disponible();
        public static Disponible estado14 = new Disponible();

        //estados rt


        public static List<Estado> Estados = new List<Estado> { estado1, estado2, estado3, estado4, estado5, estado6, estado7, estado8, estado9, estado10, estado11, estado12, estado13, estado14 };


        //cambios de estado rt
        public static CambioEstadoRT cambioEstado1RT1 = new CambioEstadoRT(estado9, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/08/05"));
        public static CambioEstadoRT cambioEstado2RT1 = new CambioEstadoRT(estado10, DateTime.Parse("2022/05/05"));


        public static CambioEstadoRT cambioEstado1RT2 = new CambioEstadoRT(estado9, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/05/05"));
        public static CambioEstadoRT cambioEstado2RT2 = new CambioEstadoRT(estado11, DateTime.Parse("2022/05/05"));

        public static CambioEstadoRT cambioEstado1RT3 = new CambioEstadoRT(estado9, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/05/05"));
        public static CambioEstadoRT cambioEstado2RT3 = new CambioEstadoRT(estado12, DateTime.Parse("2022/05/05"));

        public static CambioEstadoRT cambioEstado1RT4 = new CambioEstadoRT(estado9, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/05/05"));
        public static CambioEstadoRT cambioEstado2RT4 = new CambioEstadoRT(estado12, DateTime.Parse("2022/05/05"));

        public static CambioEstadoRT cambioEstado1RT5 = new CambioEstadoRT(estado9, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/05/05"));
        public static CambioEstadoRT cambioEstado2RT5 = new CambioEstadoRT(estado12, DateTime.Parse("2022/05/05"));

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
        public static CambioEstadoTurno cambioEstado1turno1 = new CambioEstadoTurno(estado6, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/05/05"));
        public static CambioEstadoTurno cambioEstado2turno1 = new CambioEstadoTurno(estado3, DateTime.Parse("2022/05/05"));


        public static CambioEstadoTurno cambioEstado1turno2 = new CambioEstadoTurno(estado3, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/05/05"));
        public static CambioEstadoTurno cambioEstado2turno2 = new CambioEstadoTurno(estado8, DateTime.Parse("2022/05/05"));

        public static CambioEstadoTurno cambioEstado1turno3 = new CambioEstadoTurno(estado4, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/05/05"));
        public static CambioEstadoTurno cambioEstado2turno3 = new CambioEstadoTurno(estado4, DateTime.Parse("2022/05/05"));

        public static CambioEstadoTurno cambioEstado1turno4 = new CambioEstadoTurno(estado8, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/05/05"));
        public static CambioEstadoTurno cambioEstado2turno4 = new CambioEstadoTurno(estado8, DateTime.Parse("2022/05/05"));

        public static CambioEstadoTurno cambioEstado1turno5 = new CambioEstadoTurno(estado5, DateTime.Parse("2022/05/05"), DateTime.Parse("2022/05/05"));
        public static CambioEstadoTurno cambioEstado2turno5 = new CambioEstadoTurno(estado4, DateTime.Parse("2022/05/05"));

        public static List<CambioEstadoTurno> CambiosEstadoTurnos = new List<CambioEstadoTurno> { cambioEstado1turno1, cambioEstado2turno1, cambioEstado1turno2, cambioEstado2turno2, cambioEstado1turno3, cambioEstado2turno3, cambioEstado1turno4, cambioEstado2turno4, cambioEstado1turno5, cambioEstado2turno5 };

        public static List<CambioEstadoTurno> listaCambioEstadoTurno1 = new List<CambioEstadoTurno> { cambioEstado1turno1, cambioEstado2turno1 };
        public static List<CambioEstadoTurno> listaCambioEstadoTurno2 = new List<CambioEstadoTurno> { cambioEstado1turno2,};
        public static List<CambioEstadoTurno> listaCambioEstadoTurno3 = new List<CambioEstadoTurno> { cambioEstado1turno3,};
        public static List<CambioEstadoTurno> listaCambioEstadoTurno4 = new List<CambioEstadoTurno> { cambioEstado1turno4, };
        public static List<CambioEstadoTurno> listaCambioEstadoTurno5 = new List<CambioEstadoTurno> { cambioEstado1turno5,};

        //turnos                                                                                                                                             
        public static Turno turno1 = new Turno(DateTime.Parse("14/11/2022"), "Lunes", DateTime.Parse("14/11/2022 08:30"), DateTime.Parse("14/11/2022 09:30"), listaCambioEstadoTurno1.ToList(), estado1);
        public static Turno turno13 = new Turno(DateTime.Parse("14/11/2022"), "Lunes", DateTime.Parse("14/11/2022 08:30"), DateTime.Parse("14/11/2022 09:30"), listaCambioEstadoTurno1.ToList(), estado5);
        public static Turno turno14 = new Turno(DateTime.Parse("14/11/2022"), "Lunes", DateTime.Parse("14/11/2022 08:30"), DateTime.Parse("14/11/2022 09:30"), listaCambioEstadoTurno1.ToList(), estado6);

        public static Turno turno2 = new Turno(DateTime.Parse("15/11/2022"), "Martes", DateTime.Parse("15/11/2022 08:30"), DateTime.Parse("15/11/2022 09:30"), listaCambioEstadoTurno2.ToList(), estado5);
        public static Turno turno3 = new Turno(DateTime.Parse("16/11/2022"), "Miercoles", DateTime.Parse("16/11/2022 11:30"), DateTime.Parse("16/11/2022 14:30"), listaCambioEstadoTurno3.ToList(), estado6);
        public static Turno turno4 = new Turno(DateTime.Parse("17/11/2022"), "Jueves", DateTime.Parse("17/11/2022 08:30"), DateTime.Parse("17/11/2022 09:30"), listaCambioEstadoTurno1.ToList(), estado1);
        public static Turno turno5 = new Turno(DateTime.Parse("18/11/2022"), "Viernes", DateTime.Parse("18/11/2022 18:30"), DateTime.Parse("18/11/2022 20:30"), listaCambioEstadoTurno1.ToList(), estado1);
        public static Turno turno6 = new Turno(DateTime.Parse("21/11/2022"), "Lunes", DateTime.Parse("21/11/2022 08:30"), DateTime.Parse("21/11/2022 09:30"), listaCambioEstadoTurno3.ToList(), estado6);
        public static Turno turno7 = new Turno(DateTime.Parse("22/11/2022"), "Martes", DateTime.Parse("22/11/2022 10:30"), DateTime.Parse("22/11/2022 11:30"), listaCambioEstadoTurno2.ToList(), estado1);
        public static Turno turno8 = new Turno(DateTime.Parse("23/11/2022"), "Miercoles", DateTime.Parse("23/11/2022 12:30"), DateTime.Parse("23/11/2022 13:30"), listaCambioEstadoTurno3.ToList(), estado5);
        public static Turno turno9 = new Turno(DateTime.Parse("24/11/2022"), "Jueves", DateTime.Parse("24/11/2022 08:30"), DateTime.Parse("24/11/2022 09:30"), listaCambioEstadoTurno4.ToList(), estado6);
        public static Turno turno10 = new Turno(DateTime.Parse("25/11/2022"), "Viernes", DateTime.Parse("25/11/2022 14:30"), DateTime.Parse("25/11/2022 16:30"), listaCambioEstadoTurno5.ToList(), estado1);
        public static Turno turno11 = new Turno(DateTime.Parse("28/11/2022"), "Lunes", DateTime.Parse("28/11/2022 13:30"), DateTime.Parse("28/11/2022 15:30"), listaCambioEstadoTurno4.ToList(), estado1);
        public static Turno turno12 = new Turno(DateTime.Parse("29/11/2022"), "Martes", DateTime.Parse("29/11/2022 17:30"), DateTime.Parse("29/11/2022 19:30"), listaCambioEstadoTurno5.ToList(), estado5);

        public static List<Turno> Turnos = new List<Turno> {turno1, turno2, turno3, turno4, turno5, turno6, turno7, turno8, turno9, turno10, turno11, turno12};

        public static List<Turno> turnosAsignacion1 = new List<Turno> { turno1, turno2, turno3, turno11, turno4, turno5 };
        public static List<Turno> turnosAsignacion2 = new List<Turno> {  turno6 };
        public static List<Turno> turnosAsignacion3 = new List<Turno> { turno1, turno2, turno3 };
        public static List<Turno> turnosAsignacion4 = new List<Turno> { turno4, turno5, turno6 };
        public static List<Turno> turnosAsignacion5 = new List<Turno> { turno7, turno8, turno9 };
        public static List<Turno> turnosAsignacion6 = new List<Turno> { turno10, turno12 };


        //recursos tecnologicos
        public static RecursoTecnologico RT1 = new RecursoTecnologico(100, tipoRT1, modelo1, listaCambioEstadoRT1.ToList(), Turnos, estado3);
        public static RecursoTecnologico RT2 = new RecursoTecnologico(101, tipoRT2, modelo2, listaCambioEstadoRT2.ToList(), Turnos, estado3);
        public static RecursoTecnologico RT3 = new RecursoTecnologico(102, tipoRT3, modelo3, listaCambioEstadoRT3.ToList(), Turnos, estado3);
        public static RecursoTecnologico RT4 = new RecursoTecnologico(103, tipoRT4, modelo4, listaCambioEstadoRT1.ToList(), Turnos, estado3);
        public static RecursoTecnologico RT5 = new RecursoTecnologico(104, tipoRT1, modelo5, listaCambioEstadoRT2.ToList(), Turnos, estado3);
        public static RecursoTecnologico RT6 = new RecursoTecnologico(105, tipoRT2, modelo6, listaCambioEstadoRT3.ToList(), Turnos, estado5);
        public static RecursoTecnologico RT7 = new RecursoTecnologico(104, tipoRT3, modelo7, listaCambioEstadoRT4.ToList(), Turnos, estado3);
        public static RecursoTecnologico RT8 = new RecursoTecnologico(105, tipoRT4, modelo8, listaCambioEstadoRT5.ToList(), Turnos, estado3);
        public static RecursoTecnologico RT9 = new RecursoTecnologico(104, tipoRT1, modelo9, listaCambioEstadoRT4.ToList(), Turnos, estado3);
        public static RecursoTecnologico RT10 = new RecursoTecnologico(105, tipoRT2, modelo10, listaCambioEstadoRT5.ToList(), Turnos, estado6);
        public static RecursoTecnologico RT11 = new RecursoTecnologico(104, tipoRT3, modelo11, listaCambioEstadoRT4.ToList(), Turnos, estado3);
        public static RecursoTecnologico RT12 = new RecursoTecnologico(105, tipoRT4, modelo12, listaCambioEstadoRT5.ToList(), Turnos, estado3);

        public static List<RecursoTecnologico> Recursos = new List<RecursoTecnologico> { RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12 };

        public static List<RecursoTecnologico> RecursosCI1 = new List<RecursoTecnologico> { RT1, RT2, RT3 };
        public static List<RecursoTecnologico> RecursosCI2 = new List<RecursoTecnologico> { RT4, RT5, RT6 };
        public static List<RecursoTecnologico> RecursosCI3 = new List<RecursoTecnologico> { RT7, RT8, RT9 };
        public static List<RecursoTecnologico> RecursosCI4 = new List<RecursoTecnologico> { RT10, RT11, RT12 };

        //asignacion cientificos
        public static AsignacionCientificoDelCI asignCient1 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico1, turnosAsignacion1.ToList(), DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient2 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico2, turnosAsignacion2.ToList(), DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient3 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico1, turnosAsignacion3.ToList(), DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient4 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico2, turnosAsignacion4.ToList(), DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient5 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico1, turnosAsignacion5.ToList(), DateTime.Parse("01/01/2025"));
        public static AsignacionCientificoDelCI asignCient6 = new AsignacionCientificoDelCI(DateTime.Parse("01/01/2022"), personalCientifico2, turnosAsignacion6.ToList(), DateTime.Parse("01/01/2025"));

        public static List<AsignacionCientificoDelCI> Asignaciones = new List<AsignacionCientificoDelCI> { asignCient1, asignCient2, asignCient3, asignCient4, asignCient5, asignCient6 };

        public static List<AsignacionCientificoDelCI> listaAsignacionCientifico1 = new List<AsignacionCientificoDelCI> { asignCient1, asignCient2 };
        public static List<AsignacionCientificoDelCI> listaAsignacionCientifico2 = new List<AsignacionCientificoDelCI> { asignCient3 };
        public static List<AsignacionCientificoDelCI> listaAsignacionCientifico3 = new List<AsignacionCientificoDelCI> { asignCient4, asignCient5 };
        public static List<AsignacionCientificoDelCI> listaAsignacionCientifico4 = new List<AsignacionCientificoDelCI> { asignCient6 };

        //centro de investigacion
        public static CentroDeInvestigacion CI1 = new CentroDeInvestigacion("Centro de Investigaciones Autónomo", RecursosCI1.ToList(), listaAsignacionCientifico1.ToList());
        public static CentroDeInvestigacion CI2 = new CentroDeInvestigacion("CIDS", RecursosCI2.ToList(), listaAsignacionCientifico2.ToList());
        public static CentroDeInvestigacion CI3 = new CentroDeInvestigacion("CCT", RecursosCI3.ToList(), listaAsignacionCientifico3.ToList());
        public static CentroDeInvestigacion CI4 = new CentroDeInvestigacion("CONICET", RecursosCI4.ToList(), listaAsignacionCientifico4.ToList());

        public static List<CentroDeInvestigacion> CentrosInvestigacion = new List<CentroDeInvestigacion> { CI1, CI2, CI3, CI4 };


        //interfaz

        public static InterfazMail InterfazMail = new InterfazMail();
        public static InterfazWhatsApp InterfazWhatsApp = new InterfazWhatsApp();

        public static void cargarDatos()
        {
            using (var ctx = new Contexto.Context())
            {
                
                foreach (TipoRecursoTecnologico item in TiposRT)
                {
                    ctx.TiposRecursosTecnologicos.Add(item);
                    ctx.SaveChanges();
                }
                foreach (Modelo item in Modelos)
                {
                    ctx.Modelos.Add(item);
                    ctx.SaveChanges();
                }
                foreach (Marca item in Marcas)
                {
                    ctx.Marcas.Add(item);
                    ctx.SaveChanges();
                }
                foreach (Estado item in Estados)
                {
                    ctx.Estados.Add(item);
                    ctx.SaveChanges();
                }
                
                foreach (CambioEstadoRT item in CambiosEstadoRT)
                {
                    ctx.CambioEstadoRT.Add(item);
                    ctx.SaveChanges();
                }
                foreach (PersonalCientifico item in PersonalesCientifico)
                {
                    ctx.PersonalCientifico.Add(item);
                    ctx.SaveChanges();
                }
                
                foreach (CambioEstadoTurno item in CambiosEstadoTurnos)
                {
                    ctx.CambioEstadoTurno.Add(item);
                    ctx.SaveChanges();
                }

                
                ctx.Turnos.AddRange(Turnos);
                ctx.SaveChanges();

                
                foreach (AsignacionCientificoDelCI item in Asignaciones)
                {
                    ctx.AsignacionCientificoDelCI.Add(item);
                    ctx.SaveChanges();
                } 
                
                ctx.CentroDeInvestigacion.Add(CI4);
                ctx.SaveChanges();
                ctx.CentroDeInvestigacion.Add(CI3);
                ctx.SaveChanges();
                ctx.CentroDeInvestigacion.Add(CI2);
                ctx.SaveChanges();
                ctx.CentroDeInvestigacion.Add(CI1);
                ctx.SaveChanges();
            }
        }

    }
}