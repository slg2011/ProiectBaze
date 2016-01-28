using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProiectATM.Models.Mapping
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            // Primary Key
            this.HasKey(t => t.id_stud);

            // Properties
            this.Property(t => t.id_stud)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Prenume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Parinte)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.CNP)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Adresa)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Telefon)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.Tip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.email)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Student");
            this.Property(t => t.id_stud).HasColumnName("id_stud");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.Prenume).HasColumnName("Prenume");
            this.Property(t => t.Parinte).HasColumnName("Parinte");
            this.Property(t => t.CNP).HasColumnName("CNP");
            this.Property(t => t.Adresa).HasColumnName("Adresa");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
            this.Property(t => t.Tip).HasColumnName("Tip");
            this.Property(t => t.Taxa).HasColumnName("Taxa");
            this.Property(t => t.id_grupa).HasColumnName("id_grupa");
            this.Property(t => t.Credite).HasColumnName("Credite");
            this.Property(t => t.email).HasColumnName("email");

            // Relationships
            this.HasRequired(t => t.Grupe)
                .WithMany(t => t.Students)
                .HasForeignKey(d => d.id_grupa);

        }
    }
}
