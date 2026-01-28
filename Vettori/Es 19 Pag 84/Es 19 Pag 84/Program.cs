using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_19_Pag_84
{
    internal class Program
    {
        static int LeggiNumero(string messaggio)
        {
            bool isCorrect = false;
            int numero;

            do
            {
                Console.Write(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Inserire un numero intero valido");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (isCorrect && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);

            return numero;
        }

        public static void CaricaVettoreSenzaRipetizioni(int[] vettore, int n)
        {
            Random rnd = new Random();
            bool duplicato = false;

            for (int i = 0; i < n; i++)
            {
                vettore[i] = rnd.Next(100);
                duplicato = false;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (duplicato == true)
                    {
                        break;
                    }

                    if (vettore[i] == vettore[j])
                    {
                        duplicato = true;
                        i--;
                    }
                }
            }

        }

        static void StampaVettore(int[] vettore)
        {
            Console.WriteLine("\nContenuto del vettore:");
            for (int i = 0; i < vettore.Length; i++)
                Console.WriteLine($"Elemento {i + 1}: {vettore[i]}");
        }


        static void Main(string[] args)
        {
            int n = LeggiNumero("inserisci la lunghezza del vettore: ");

            int[] vettore = new int[n];

            CaricaVettoreSenzaRipetizioni(vettore, n);

            Console.Write("Ecco il vettore");
            StampaVettore(vettore);

        }
    }
}
