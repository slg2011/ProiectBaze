using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProiectATM.Models.Mapping
{
    public class AdministratorMap : EntityTypeConfiguration<Administrator>
    {
        public AdministratorMap()
        {
            // Primary Key
            this.HasKey(t => t.id_admin);

            // Properties
            this.Property(t => t.id_admin)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Prenume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Administrator");
            this.Property(t => t.id_admin).HasColumnName("id_admin");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.Prenume).HasColumnName("Prenume");
        }
    }
}
