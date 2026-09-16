using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_14_Pag_115
{
    internal class Program
    {
        static string[] titoli = {
            "1984",
            "Fahrenheit 451",
            "Harry Potter e la pietra filosofale",
            "Il signore degli anelli",
            "Il nome della rosa",
            "Il piccolo principe",
            "La coscienza di Zeno",
            "Orgoglio e pregiudizio",
            "I promessi sposi",
            "Il codice Da Vinci"
        };

        static string[] generi = {
            "Fantascienza",
            "Fantascienza",
            "Fantasy",
            "Fantasy",
            "Giallo storico",
            "Narrativa",
            "Narrativa",
            "Romanzo",
            "Romanzo storico",
            "Thriller"
        };

        static string[] caseEditrici = {
            "Mondadori",
            "Mondadori",
            "Salani",
            "Bompiani",
            "Bompiani",
            "Bompiani",
            "Newton Compton",
            "Feltrinelli",
            "Garzanti",
            "Mondadori"
        };

        static int ContaLibriConRicercaSequenziale4(string genere, string editore)
        {
            int i = 0;
            int j = 0;
            bool superato = false;
            int[] vettorePosizione = new int[titoli.Length];

            while (i < titoli.Length && !superato)
            {
                if (generi[i].CompareTo(genere) > 0)
                {
                    superato = true;
                }
                else if (generi[i] == genere)
                {
                    if (caseEditrici[i] == editore)
                    {
                        vettorePosizione[j] = i;
                        Console.WriteLine("Trovato all'indice " + i + ": " + titoli[i]);
                        j++;
                    }
                }
                i++;
            }

            return j;
        }

        static void Main(string[] args)
        {
            Console.Write("Inserisci il genere: ");
            string genereUtente = Console.ReadLine();

            Console.Write("Inserisci la casa editrice: ");
            string editoreUtente = Console.ReadLine();

            int numeroTrovati = ContaLibriConRicercaSequenziale4(genereUtente, editoreUtente);

            if (numeroTrovati > 0)
            {
                Console.WriteLine("\nTotale libri trovati: " + numeroTrovati);
            }
            else
            {
                Console.WriteLine("\nNessun libro corrisponde ai criteri inseriti.");
            }

            Console.ReadKey();
        }
    }
}
