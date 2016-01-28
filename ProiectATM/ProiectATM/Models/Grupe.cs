using System;
using System.Collections.Generic;

namespace ProiectATM.Models
{
    public partial class Grupe
    {
        public Grupe()
        {
            this.Students = new List<Student>();
        }

        public int id_grupa { get; set; }
        public string nume_grupa { get; set; }
        public int an { get; set; }
        public int nr_std { get; set; }
        public string indrumator { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
