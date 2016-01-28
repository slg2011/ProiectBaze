using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProiectATM.Models.Mapping
{
    public class DisciplinaMap : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaMap()
        {
            // Primary Key
            this.HasKey(t => t.id_disc);

            // Properties
            this.Property(t => t.Denumire)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Disciplina");
            this.Property(t => t.id_disc).HasColumnName("id_disc");
            this.Property(t => t.Denumire).HasColumnName("Denumire");
            this.Property(t => t.Nr_credite).HasColumnName("Nr_credite");
        }
    }
}
