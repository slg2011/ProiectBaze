using System;
using System.Collections.Generic;

namespace ProiectATM.Models
{
    public partial class Student
    {
        public Student()
        {
            this.Notes = new List<Note>();
            this.Restantieris = new List<Restantieri>();
        }

        public int id_stud { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Parinte { get; set; }
        public string CNP { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Tip { get; set; }
        public Nullable<double> Taxa { get; set; }
        public int id_grupa { get; set; }
        public int Credite { get; set; }
        public string email { get; set; }
        public virtual Grupe Grupe { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Restantieri> Restantieris { get; set; }
    }
}
