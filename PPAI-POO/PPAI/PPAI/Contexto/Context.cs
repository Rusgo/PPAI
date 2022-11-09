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
        public Context() : base("Data Source=200.69.137.167,11333;Initial Catalog=DSI_3K1_grupo7;User ID=DSI_3K1_grupo7;Password=..DSI_3K1_grupo7?")
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
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<PersonalCientifico> PersonalCientifico { get; set; }
        public DbSet<RecursoTecnologico> RecursosTecnologicos { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<TipoRecursoTecnologico> TiposRecursosTecnologicos { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
