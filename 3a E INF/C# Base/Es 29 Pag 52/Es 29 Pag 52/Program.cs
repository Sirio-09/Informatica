using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es29_Pag52
{
    internal class Program
    {
        static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            bool isCorrect = false;
            int numero;

            do
            {
                Console.Write(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il prezzo deve essere maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return numero;
        }

        private static void TrovaFattori(int n)
        {
            Console.Write($"I fattori di {n} sono: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserisci un numero: ");
            TrovaFattori(n);

            Console.ReadKey();
        }
    }
}
