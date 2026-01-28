using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_32_Pag_52
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

        private static void VerificaNumeroPrimo(int n)
        {
            bool primo = true;
            if (n != 1 && n != 2)
            {
                int div = 2;
                do
                {
                    if (n % div == 0)
                    {
                        primo = false;
                    }
                    else
                    {
                        primo = true;
                        div++;
                    }
                } while (div < n && primo);
            }
            else if (n == 1)
            {
                primo = false;
            }
            else if (n == 2)
            {
                primo = true;
            }
            if (primo)
            {
                Console.WriteLine($"Il numero {n} è primo");
            }
            else
            {
                Console.WriteLine($"Il numero {n} non è primo");
            }
        }
        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserisci un numero: ");
            VerificaNumeroPrimo(n);

            Console.ReadKey();
        }
    }
}
