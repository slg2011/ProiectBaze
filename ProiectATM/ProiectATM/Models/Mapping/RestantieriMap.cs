using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProiectATM.Models.Mapping
{
    public class RestantieriMap : EntityTypeConfiguration<Restantieri>
    {
        public RestantieriMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id_disc, t.id_stud, t.id_prof, t.nota });

            // Properties
            this.Property(t => t.id_disc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_stud)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id_prof)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nota)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Restantieri");
            this.Property(t => t.id_disc).HasColumnName("id_disc");
            this.Property(t => t.id_stud).HasColumnName("id_stud");
            this.Property(t => t.id_prof).HasColumnName("id_prof");
            this.Property(t => t.nota).HasColumnName("nota");

            // Relationships
            this.HasRequired(t => t.Disciplina)
                .WithMany(t => t.Restantieris)
                .HasForeignKey(d => d.id_disc);
            this.HasRequired(t => t.Profesor)
                .WithMany(t => t.Restantieris)
                .HasForeignKey(d => d.id_prof);
            this.HasRequired(t => t.Student)
                .WithMany(t => t.Restantieris)
                .HasForeignKey(d => d.id_stud);

        }
    }
}
