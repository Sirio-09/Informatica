using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Es_3
{
    internal class Program
    {

        private static void RicercaNome(string[] names, string name)
        {
            bool trovata = false;

            for (int i = 0; i < names.Length; i++)
            {
                if(names[i] == name)
                {
                    Console.WriteLine("Il nome " + name + " è presente alla posizione " + i);
                    trovata = true;
                }
            }

            if (!trovata)
            {
                Console.WriteLine(name + " non è presente");
            }
        }


        static void Main(string[] args)
        {
            string[] names = { "Paola", "Roberto", "Chiara", "Paola", "Giuseppe", "Ines", "Giorgia", "Maurizio", "Mimmo", "Giacomo" };

            Console.WriteLine("Inserisci un nome da cercare: ");
            string name = Console.ReadLine();

            RicercaNome(names, name);

            Console.ReadKey();

        }
    }
}
