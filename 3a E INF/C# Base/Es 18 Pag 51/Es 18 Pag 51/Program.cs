using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Es_18_Pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double hamburger = 3.50;
            double milkshake = 1.80;
            double cheesburger = 4.20;

            int ordinazione;

            int quantitàH = 0;
            int quantitàC = 0;
            int quantitàM = 0;

            double totale = 0;

            do
            {
                Console.WriteLine("Premi 1 per ordinare un Hamburger\nPremi 2 per ordinare un Cheesburger\nPremi 3 per ordinare un Milkshake\nPremi 0 per concludere l'ordine\n");
                Console.WriteLine("Hamburger ordinati: " + quantitàH);
                Console.WriteLine("Cheesburger ordinati: " + quantitàC);
                Console.WriteLine("Milkshake ordinati: " + quantitàM);

                ordinazione = Convert.ToInt32(Console.ReadLine());


                if (ordinazione == 1)
                {
                    Console.WriteLine("Inserire la quantità desiderata di Hamburger");
                    quantitàH = Convert.ToInt32(Console.ReadLine());

                    totale = totale + quantitàH * hamburger;

                    Console.Clear();
                }

                if (ordinazione == 2)
                {
                    Console.WriteLine("Inserire la quantità desiderata di Cheesburger");
                    quantitàC = Convert.ToInt32(Console.ReadLine());

                    totale = totale + quantitàC * cheesburger;

                    Console.Clear();
                }

                if (ordinazione == 3)
                {
                    Console.WriteLine("Inserire la quantità desiderata di Milkshake");
                    quantitàM = Convert.ToInt32(Console.ReadLine());

                    totale = totale + quantitàM * milkshake;

                    Console.Clear();
                }

                if (ordinazione != 0 && ordinazione != 1 && ordinazione != 2 &&  ordinazione != 3)
                {
                    Console.WriteLine("ERRORE");

                    Console.Clear();
                }

            } while (ordinazione != 0);

            Console.WriteLine("Il totale è " + totale);
            Console.ReadLine();


        }
    }
}
