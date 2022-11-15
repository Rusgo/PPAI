using PPAI.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Contexto
{
    public class Context : DbContext
    {
        public Context() : base("Data Source=DESKTOP-MA4HMUC\\SQLEXPRESS;Initial Catalog=2;Integrated Security=True")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());

        }

        public static Context Create()
        {
            return new Context();
        }

        public DbSet<AsignacionCientificoDelCI> AsignacionCientificoDelCI { get; set; }
        public DbSet<CambioEstadoRT> CambioEstadoRT { get; set; }
        public DbSet<CambioEstadoTurno> CambioEstadoTurno { get; set; }
        public DbSet<CentroDeInvestigacion> CentroDeInvestigacion { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Disponible> Disponibles { get; set; }
        public DbSet<Reservado> Seleccionados { get; set; }

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<PersonalCientifico> PersonalCientifico { get; set; }
        public DbSet<RecursoTecnologico> RecursosTecnologicos { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<TipoRecursoTecnologico> TiposRecursosTecnologicos { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Turno>().HasMany(x => x.CambioEstadoTurno).WithMany().Map(M=>M.ToTable("turnoXcet"));
            modelBuilder.Entity<RecursoTecnologico>().HasMany(x => x.Turnos).WithMany().Map(M => M.ToTable("IntermediaRTxTurnos"));
            modelBuilder.Entity<RecursoTecnologico>().HasMany(x => x.CambioEstadoRT).WithMany().Map(M => M.ToTable("IntermediaRTxcert"));

            base.OnModelCreating(modelBuilder);
         }
    }
}
