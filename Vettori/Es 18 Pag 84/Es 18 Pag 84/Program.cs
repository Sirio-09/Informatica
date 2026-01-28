using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_18_Pag_84
{
    internal class Program
    {
        public static void CaricaVettore(int[] vettore, int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                vettore[i] = rnd.Next(100);
            }
        }

        public static int[] OrdinaVettorePerCrescente(int[] vettore)
        {
            int[] vettoreAus = new int[vettore.Length];

            for (int i = 0; i < vettore.Length - 1; i++)
            {
                for (int j = 0; j < vettore.Length - 1 - i; j++)
                {
                    if (vettore[j] > vettore[j + 1])
                    {
                        vettoreAus[j] = vettore[j];

                        vettore[j] = vettore[j +1];

                        vettore[j +1] = vettoreAus[j];
                    }
                }
            }
            return vettore;
        }
            
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


        static void Main(string[] args)
        {
            int n = LeggiNumero("inserisci la lunghezza del vettore: ");

            int[] vettore = new int[n];

            CaricaVettore(vettore, n);

            Console.WriteLine("Il vettore non ordinato: ");
            StampaVettore(vettore);

            OrdinaVettorePerCrescente(vettore);

            Console.Write("");
            Console.WriteLine("Vettore ordinato");

            StampaVettore(vettore);
        }

        static void StampaVettore(int[] vettore)
        {
            Console.WriteLine("\nContenuto del vettore:");
            for (int i = 0; i < vettore.Length; i++)
                Console.WriteLine($"Elemento {i + 1}: {vettore[i]}");
        }
    }
}
