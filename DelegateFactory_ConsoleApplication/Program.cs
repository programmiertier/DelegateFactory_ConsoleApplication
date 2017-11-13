using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DelegateFactory_ConsoleApplication
{
    class Program
    {
        public delegate void Del_Katz(string kaetzchen);

        static void Main(string[] args)
        {
            Del_Katz Katze_bauen = new Del_Katz((string miez) => { });

            List<Del_Katz> katzenliste = new List<Del_Katz>() {
                                                    StepsToBuild.rohKatze_bereitstellen,
                                                    StepsToBuild.pfoten_bereitstellen,
                                                    StepsToBuild.pfoten_einsetzen,
                                                    StepsToBuild.schnurrhaare_montieren,
                                                    StepsToBuild.pfoten_schnurrhaare_verbinden  };
            foreach(var sprung in katzenliste)
            {
                Katze_bauen += sprung;
            }
            Katze_bauen("Sally");
            ReadLine();
            Katze_bauen("Jack");
            ReadLine();
            Katze_bauen("Lilith");
            ReadLine();
            Katze_bauen("Aurora");

        }
    }
}
