using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_2
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

                if (n == 0 || n < 0)
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

        private static void CaricaVettore(int[] vet, int n)
        {
            int i = 0;
            

            while(i < vet.Length)
            {
                bool duplicato = false;

                int newNumber = rnd.Next(0, n*2);

                for (int j = 0; j < n; j++)
                {
                    if (vet[j] == newNumber)
                    {
                        duplicato = true;
                        break;
                    }
                }

                if (!duplicato)
                {
                    vet[i] = newNumber;
                    i++;
                }
            }
        }

        private static void StampaVettore(int[] vet)
        {
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserisci la lunghezza del vettore: ");

            int[] vet = new int[n];
            CaricaVettore(vet, n);

            StampaVettore(vet);

            Console.ReadKey();
        }
    }
}
