using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_33_Pag_52
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
                    Console.WriteLine("Il numero deve essere maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return numero;
        }

        private static int ControllaDeficente(int n)
        {
            int i = 1;
            int res = 0;
            do
            {
                if (n == 1)
                {
                    return 0;
                }

                if (n % i == 0)
                {
                    res += i;
                }

                i++;
            } while (i < n);

            return res;
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserisci un numero: ");

            int res = ControllaDeficente(n);
            
            if (res < n)
            {
                Console.WriteLine("Il numero "+ n + " è deficente");
            }
            else
            {
                Console.WriteLine("Il numero " + n + " non è deficente");
            }

            Console.ReadKey();
        }
    }
}
