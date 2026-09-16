using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_3_Pag_115
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

        private static void OrdinaVettori(string[] cognomi, string[] nomi, string[] cognomi_nomi, int inizio, int fine)
        {

        }

        private static void UnisciVettori(string[] vetUnione, string[] vet1, string[] vet2)
        {
            for(int i = 0; i < vet1.Length; i++)
            {
                vetUnione[i] = vet1[i] + " " + vet2[i];
            }
        }

        static void Main(string[] args)
        {
            string[] cognomi = { "Barbieri", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca", "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi", "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };
            string[] nomi = {  "Andrea", "Alessandro", "Anna", "Chiara", "Daniela", "Davide", "Elena", "Federico", "Filippo", "Francesca", "Giacomo", "Giorgia", "Luca", "Marco", "Martina", "Matteo", "Michele", "Sara", "Simone", "Valentina" };
            string[] classi = { "1A", "1A", "1A", "1A", "1A", "1A", "1A", "1A", "2A", "2A", "2A", "2A", "3A", "3A", "3A", "2A", "1A", "3A", "1A", "2A" };

            string[] cognomi_nomi = new string[cognomi.Length];

            UnisciVettori(cognomi_nomi, cognomi, nomi);

            Console.Write("Inserisci la classe da cercare (con la lettera maiuscola): ");
            string classe = Console.ReadLine().ToUpper();
            Console.WriteLine();

            int inizio = cognomi.Length - cognomi.Length;
            int fine = cognomi.Length;


            StampaAlunni(classe, nomi, cognomi, classi);


        }


    }
}
