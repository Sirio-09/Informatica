using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        private static void BubbleSort(string[] vet)
        {
            int i = -1;
            bool scambio;

            do
            {
                i++;
                scambio = false;

                for (int j = vet.Length - 2; j >= i; j--)
                {
                    if (vet[j].CompareTo(vet[j + 1]) > 0)
                    {
                        string aus = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aus;

                        scambio = true;
                    }
                }

            } while (scambio && i < vet.Length - 1);
        }

        private static void StampaVettore(string[] vet)
        {
            for(int i = 0; i <  vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }


        static void Main(string[] args)
        {
            string[] names = { "Barbara", "Alberto", "Paola", "Domenico", "Vincenzo", "Beatrice" };

            StampaVettore(names);

            Console.WriteLine();
            Console.WriteLine();

            BubbleSort(names);
            StampaVettore(names);

            Console.ReadKey();

            
        }
    }
}
