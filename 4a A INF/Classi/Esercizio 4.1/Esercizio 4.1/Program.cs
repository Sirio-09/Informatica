using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contatore c1 = Contatore.CreaContatore();

            for(int i = 0; i < 10; i++)
            {
                int valore = c1.Incrementa();
                Console.WriteLine(valore);
            }

            Console.WriteLine();

            int nuovoValore = c1.Azzera();
            Console.WriteLine(nuovoValore);
        }
    }
}
