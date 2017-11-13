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
            /*Del_Katz miez;

            miez = new Del_Katz(StepsToBuild.rohKatze_bereitstellen);
            miez += new Del_Katz(StepsToBuild.pfoten_bereitstellen);
            miez += new Del_Katz(StepsToBuild.pfoten_einsetzen);
            miez += new Del_Katz(StepsToBuild.schnurrhaare_montieren);
            miez += new Del_Katz(StepsToBuild.pfoten_schnurrhaare_verbinden);

            /* miez("Schnurri");
            ReadLine();

            miez -= new Del_Katz(StepsToBuild.pfoten_schnurrhaare_verbinden);
            miez("Mauzi");
            ReadLine();*/

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
            Katze_bauen("mauzi");
            ReadLine();
            Katze_bauen("miez");
            ReadLine();
            Katze_bauen("Sally");
            ReadLine();
            Katze_bauen("Aurora");

        }
    }
}
