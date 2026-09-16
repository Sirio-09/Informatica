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

        private static bool ControllaAbbondante(int n1, int n2)
        {
            int i = 1;
            int j = 1;

            int res1 = 0;
            int res2 = 0;
            do
            {
                if (n1 % i == 0)
                {
                    res1 += i;
                }

                i++;
            } while (i < n1);

            do
            {
                if (n2 % j == 0)
                {
                    res2 += j;
                }

                j++;
            } while (j < n2);


            if(res1 == n2 && res2 == n1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            int n1 = LeggiNumero("Inserisci il primo numero: ");
            int n2 = LeggiNumero("Inserisci il secondo numero: ");

            if (ControllaAbbondante(n1, n2))
            {
                Console.WriteLine("Il numero " +  n1 + " e il numero " + n2 + " sono amichevoli");
            }
            else
            {
                Console.WriteLine("Il numero " + n1 + " e il numero " + n2 + " non sono amichevoli");
            }

            Console.ReadKey();
        }
    }
}