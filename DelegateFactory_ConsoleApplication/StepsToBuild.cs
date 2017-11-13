using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DelegateFactory_ConsoleApplication
{
    class StepsToBuild
    {
        public static void rohKatze_bereitstellen(string katzi)
        {
            WriteLine("Die Rohkatze_bereitstellen ({0})", katzi);
        }
        public static void pfoten_bereitstellen(string katzi)
        {
            WriteLine("Die Pfoten bereitstellen ({0})", katzi);
        }
        public static void schnurrhaare_montieren(string katzi)
        {
            WriteLine("Die Schnurrhaare montieren ({0})", katzi);
        }
        public static void pfoten_einsetzen(string katzi)
        {
            WriteLine("Die Pfoten einsetzen ({0})", katzi);
        }
        public static void pfoten_schnurrhaare_verbinden(string katzi)
        {
            WriteLine("Die Pfoten und Schnurrhaare verbinden ({0})", katzi);
        }
    }
}
