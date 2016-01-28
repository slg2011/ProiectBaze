using System;
using System.Collections.Generic;

namespace ProiectATM.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            this.Notes = new List<Note>();
            this.Restantieris = new List<Restantieri>();
        }

        public int id_prof { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Departament { get; set; }
        public string Statut { get; set; }
        public string email { get; set; }
        public string Tip { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Restantieri> Restantieris { get; set; }
    }
}
