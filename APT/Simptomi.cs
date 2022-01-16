using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APT
{
    public class Simptom
    {
        public static List<string> simptomi = new List<string>();

        public static void dodajSimptom(string simptom)
        {
            simptomi.Add(simptom);
        }
    }
}
