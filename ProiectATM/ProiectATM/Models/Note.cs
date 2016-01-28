using System;
using System.Collections.Generic;

namespace ProiectATM.Models
{
    public partial class Note
    {
        public int Nota { get; set; }
        public Nullable<int> Credite_obt { get; set; }
        public int id_disc { get; set; }
        public int id_stud { get; set; }
        public int id_prof { get; set; }
        public string forma { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Student Student { get; set; }
    }
}
