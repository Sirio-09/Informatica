using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_20_Pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double g;
            double m = 0.20;

            double mTot;

            do
            {
                Console.Clear();

                Console.WriteLine("Inserire il numero di giorni");
                g = Convert.ToInt32(Console.ReadLine());

            } while (g < 0);
            

            if (g > 15)
            {
                g = g - 15;
                mTot = g * m;

                Console.WriteLine("Ci sono " + g + " giorni di ritardo perciò la multa è di " + mTot + " Euro");

                Console.ReadKey();
                return;

            }
            else
            {

                Console.WriteLine("Non ci sono multe da applicare");

                Console.ReadKey();
                return;

            }

        }
    }
}
