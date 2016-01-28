using System;
using System.Collections.Generic;

namespace ProiectATM.Models
{
    public partial class LogInn
    {
        public int id { get; set; }
        public string username { get; set; }
        public string parola { get; set; }
        public int permis { get; set; }
    }
}
