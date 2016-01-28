using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProiectATM.Models.Mapping
{
    public class ProfesorMap : EntityTypeConfiguration<Profesor>
    {
        public ProfesorMap()
        {
            // Primary Key
            this.HasKey(t => t.id_prof);

            // Properties
            this.Property(t => t.id_prof)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Prenume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Telefon)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Departament)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Statut)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.email)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Tip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Profesor");
            this.Property(t => t.id_prof).HasColumnName("id_prof");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.Prenume).HasColumnName("Prenume");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
            this.Property(t => t.Departament).HasColumnName("Departament");
            this.Property(t => t.Statut).HasColumnName("Statut");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.Tip).HasColumnName("Tip");
        }
    }
}
