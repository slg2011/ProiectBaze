using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProiectATM.Models.Mapping
{
    public class GrupeMap : EntityTypeConfiguration<Grupe>
    {
        public GrupeMap()
        {
            // Primary Key
            this.HasKey(t => t.id_grupa);

            // Properties
            this.Property(t => t.nume_grupa)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.indrumator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Grupe");
            this.Property(t => t.id_grupa).HasColumnName("id_grupa");
            this.Property(t => t.nume_grupa).HasColumnName("nume_grupa");
            this.Property(t => t.an).HasColumnName("an");
            this.Property(t => t.nr_std).HasColumnName("nr_std");
            this.Property(t => t.indrumator).HasColumnName("indrumator");
        }
    }
}
