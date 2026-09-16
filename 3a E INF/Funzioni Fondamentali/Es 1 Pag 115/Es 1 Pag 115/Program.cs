using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Es1Pag115
{
    internal class Program
    {
        static void StampaAlunni(string classe, string[] nomi, string[] cognomi, string[] classi)
        {
            bool trovata = false;
            for (int i = 0; i < classi.Length; i++)
            {
                if (classi[i] == classe)
                {
                    Console.WriteLine($"{nomi[i]} {cognomi[i]}");
                    trovata = true;
                }
            }
            if (!trovata)
            {
                Console.WriteLine("Classe non trovata");
            }
        }

        static void Main(string[] args)
        {
            string[] cognomi = { "Agosti", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca", "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi", "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };
            string[] nomi = { "Alessandro", "Andrea", "Anna", "Chiara", "Daniela", "Davide", "Elena", "Federico", "Filippo", "Francesca", "Giacomo", "Giorgia", "Luca", "Marco", "Martina", "Matteo", "Michele", "Sara", "Simone", "Valentina" };
            string[] classi = { "1A", "1A", "1A", "1A", "1A", "1A", "1A", "1A", "2A", "2A", "2A", "2A", "3A", "3A", "3A", "2A", "1A", "3A", "1A", "2A" };

            Console.Write("Inserisci la classe da cercare (con la lettera maiuscola): ");
            string classe = Console.ReadLine();
            Console.WriteLine();

            StampaAlunni(classe, nomi, cognomi, classi);

            Console.ReadKey();
        }

    }
}
