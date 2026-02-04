using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_13_Pag_115
{
    internal class Program
    {
        static string[] titoli = { "1984", "Fahrenheit 451", "Harry Potter e la pietra filosofale", "I promessi sposi", "Il codice Da Vinci", "Il nome della rosa", "Il piccolo principe", "Il signore degli anelli", "La coscienza di Zeno", "Orgoglio e pregiudizio" };
        static string[] generi = { "Fantascienza", "Fantascienza", "Fantasy", "Romanzo storico", "Thriller", "Giallo storico", "Narrativa", "Fantasy", "Narrativa", "Romanzo" };
        static string[] caseEditrici = { "Mondadori", "Mondadori", "Salani", "Garzanti", "Mondadori", "Bompiani", "Bompiani", "Bompiani", "Newton Compton", "Feltrinelli" };

        static int ContaLibriConRicercaSequenziale4(string genere, string editore)
        {
            int i = 0;
            int j = 0;
            bool superato = false;
            int[] vettorePosizione = new int[titoli.Length];

            while (i < titoli.Length && !superato)
            {
                if (generi[i] == genere && caseEditrici[i] == editore)
                {
                    vettorePosizione[j] = i;
                    Console.WriteLine("Trovato all'indice " + i + ": " + titoli[i]);
                    j++;
                }
                else
                {
                    if (genere.CompareTo(generi[i]) < 0)
                    {
                        superato = true;
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


