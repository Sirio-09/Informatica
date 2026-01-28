using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_1
{
    internal class Program
    {
        static Random rnd = new Random();

        private static int LeggiNumero(string messaggio)
        {
            bool isCorrect = false;
            int n;
            do
            {
                Console.WriteLine(messaggio);
                int.TryParse(Console.ReadLine(), out n);

                if(n == 0 || n < 0)
                {
                    Console.WriteLine("Il numero deve essere maggiore di 0!");
                    isCorrect = false;
                }
                else if (n > 0)
                {
                    isCorrect = true;
                }

            } while (!isCorrect);

            return n;
        }

        private static void CaricaVettore(int[] vet)
        {
            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 10);
            }
        }

        private static int TreElementiMaggiori(int[] vet, int n)
        {
            int max1 = int.MinValue;
            int max2 = int.MaxValue;
            int max3 = int.MinValue;

            for(int i = 0; i < n; i++)
            {
                int num = vet[i];

                if (num > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = num;
                }
                else if(num > max2)
                {
                    max3 = max2;
                    max2 = num;
                }
                else if(num > max3)
                {

                }
            }
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserisci la lunghezza del vettore: ");

            int[] vet = new int[n];
            CaricaVettore(vet, n);    

        }
    }
}
