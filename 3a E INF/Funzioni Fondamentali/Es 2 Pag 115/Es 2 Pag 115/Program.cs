using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_2_Pag_115
{
    internal class Program
    {
        private static void StampaAlunni(string classe, string[] nomi, string[] cognomi, string[] classi)
        {
            bool trovato = false;
            bool superato = false;
            int i = 0;
            int j = 0;

            while (i < classi.Length && !superato)
            {
                if (classi[i] == classe)
                {
                    trovato = true;
                    j++;

                    Console.WriteLine($"{nomi[i]} {cognomi[i]}");
                }
                else if (classe.CompareTo(classi[i]) < 0)
                {
                    superato = true;
                }

                i++;
            }

            if (!trovato)
            {
                Console.WriteLine("CLasse non trovata");
            }

        }

        static void Main(string[] args)
        {
            string[] cognomi = { "Agosti", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca", "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi", "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };
            string[] nomi = { "Alessandro", "Andrea", "Anna", "Chiara", "Daniela", "Davide", "Elena", "Federico", "Filippo", "Francesca", "Giacomo", "Giorgia", "Luca", "Marco", "Martina", "Matteo", "Michele", "Sara", "Simone", "Valentina" };
            string[] classi = { "1A", "1A", "1A", "1A", "1A", "1A", "1A", "2A", "2A", "2A", "2A", "2A", "2A", "2A", "3A", "3A", "3A", "3A", "3A", "3A" };

            Console.Write("Inserisci la classe da cercare (con la lettera maiuscola): ");
            string classe = Console.ReadLine();
            Console.WriteLine();

            StampaAlunni(classe, nomi, cognomi, classi);

            Console.ReadKey();
        }
    }
}
