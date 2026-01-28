using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_21_Pag_84
{
    internal class Program
    {
        static void CaricaVettoreCasuale(int[] vettore)
        {
            Random rnd = new Random();
            for (int i = 0; i < vettore.Length; i++)
                vettore[i] = rnd.Next(100);
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
        static void StampaVettore(int[] vettore)
        {
            Console.WriteLine("\nContenuto del vettore:");
            for (int i = 0; i < vettore.Length; i++)
                Console.WriteLine($"Elemento {i + 1}: {vettore[i]}");
        }

        public static int[] SpostaVettore(int[] vettore)
        {
            int[] vettoreAus = new int[vettore.Length];

            int i = 0;
            int j = vettore.Length - 1;
            int k = 1;

            vettoreAus[i] = vettore[j];

            while (k < vettore.Length)
            {
                vettoreAus[k] = vettore[i];
                i++;
                k++;
            }

            return vettoreAus;
        }


        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserisci la lunghezza del vettore: ");
            int[] vettore = new int[n];

            CaricaVettoreCasuale(vettore);

            StampaVettore(vettore);

            int[] vettoreSpostato = SpostaVettore(vettore);

            Console.WriteLine();
            Console.Write("Ecco il vettore con il contenuto spostato di una posizione:");

            StampaVettore(vettoreSpostato);

        }
    }
}
