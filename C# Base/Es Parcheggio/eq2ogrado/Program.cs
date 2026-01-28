using System;
 using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Perrone_Sirio_Esercizio_Parcheggio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int prize = 0;
            int count = 0;
            int ora_entrata;
            int ora_uscita;
            int ora_totale;

            do
            { 
                Console.Write("Inserire l'ora d'entrata ");
                ora_entrata = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserire l'ora d'uscita ");
                ora_uscita = Convert.ToInt32(Console.ReadLine());

            }while (ora_entrata > ora_uscita);

            ora_totale = ora_uscita - ora_entrata;


            if (ora_totale > 0)
            {

                do
                {
                    count = count + 1;

                    if (count == 1)
                    {

                        prize = prize + 4;

                    }
                    else if (count > 1 && count < 6)
                    {

                        prize = prize + 3;

                    }
                    else if (count > 5)
                    {

                        prize = prize + 2;

                    }

                    

                } while (count != ora_totale);
            }


            Console.WriteLine("Il Costo toale è di", prize);

            Console.ReadKey();

        }
    }
}
