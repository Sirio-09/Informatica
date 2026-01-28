using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Es_19_Pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PrezzoM = 12;
            double PrezzoF = (PrezzoM * 30) / 100;
            int nRagazzi;
            int nRagazze;
            double tot;

            do
            {
                Console.WriteLine("Inserire il numero di Ragazzi");
                nRagazzi = Convert.ToInt32(Console.ReadLine());

            } while (nRagazzi < 0);

            do
            {
                Console.WriteLine("Inserire il numero delle Ragazze");
                nRagazze = Convert.ToInt32(Console.ReadLine());

            }while (nRagazze < 0);

            Console.Clear();

            tot = (nRagazzi * PrezzoM) + (nRagazze * PrezzoF);

            Console.WriteLine("Il prezzo totale è " + tot);
            Console.ReadKey();
        }
    }
}
