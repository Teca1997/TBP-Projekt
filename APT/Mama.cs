using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APT
{
    public static class Mama
    {
        public static int id { get; set; }
        public static string ime { get; set; }
        public static string prezime { get; set; }
        public static string email { get; set; }
        public static string lozinkaHash { get; set; }
        public static DateTime zadnjiLogin { get; set; }
        public static DateTime terminPoroda { get; set; }

        public static List<Simptom> simptomi = new List<Simptom>();
    }
}
