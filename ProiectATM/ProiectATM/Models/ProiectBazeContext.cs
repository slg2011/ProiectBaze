using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ProiectATM.Models.Mapping;

namespace ProiectATM.Models
{
    public partial class ProiectBazeContext : DbContext
    {
        static ProiectBazeContext()
        {
            Database.SetInitializer<ProiectBazeContext>(null);
        }

        public ProiectBazeContext()
            : base("Name=ProiectBazeContext")
        {
        }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Grupe> Grupes { get; set; }
        public DbSet<LogInn> LogInns { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Profesor> Profesors { get; set; }
        public DbSet<Restantieri> Restantieris { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdministratorMap());
            modelBuilder.Configurations.Add(new DisciplinaMap());
            modelBuilder.Configurations.Add(new GrupeMap());
            modelBuilder.Configurations.Add(new LogInnMap());
            modelBuilder.Configurations.Add(new NoteMap());
            modelBuilder.Configurations.Add(new ProfesorMap());
            modelBuilder.Configurations.Add(new RestantieriMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
