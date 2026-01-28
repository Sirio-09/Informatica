using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_10_Pag_115
{
    internal class Program
    {
        static void CercaFilm(string[] t, int[] a, string[] r, int dimensione, string cercaRegista)
        {
            bool trovato = false;

            for (int i = 0; i < dimensione; i++)
            {
                if (a[i] >= 2010 && a[i] <= 2012 && r[i] == cercaRegista)
                {
                    Console.WriteLine("Titolo: " + t[i] + " | Anno: " + a[i]);
                    trovato = true;
                }
            }

            if (trovato == false)
            {
                Console.WriteLine("Nessun film trovato per il regista " + cercaRegista + " nel periodo 2010-2012.");
            }
        }

        static void Main(string[] args)
        {
            int n = 5;
            string[] titoli = { "Inception", "The Avengers", "Hugo Cabret", "Interstellar", "Toy Story 3" };
            int[] anni = { 2010, 2012, 2011, 2014, 2010 };
            string[] registi = { "Christopher Nolan", "Joss Whedon", "Martin Scorsese", "Christopher Nolan", "Lee Unkrich" };


            Console.Write("Inserisci il nome del regista da cercare: ");
            string registaInput = Console.ReadLine();

            Console.WriteLine("\n--- Risultati Ricerca ---");
            CercaFilm(titoli, anni, registi, n, registaInput);

            Console.ReadKey();
        }
    }
}
