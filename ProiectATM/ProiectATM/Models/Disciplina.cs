using System;
using System.Collections.Generic;

namespace ProiectATM.Models
{
    public partial class Disciplina
    {
        public Disciplina()
        {
            this.Notes = new List<Note>();
            this.Restantieris = new List<Restantieri>();
        }

        public int id_disc { get; set; }
        public string Denumire { get; set; }
        public int Nr_credite { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Restantieri> Restantieris { get; set; }
    }
}
