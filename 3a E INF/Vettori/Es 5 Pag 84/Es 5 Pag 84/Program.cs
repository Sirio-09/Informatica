using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_5_Pag_84
{
    internal class Program
    {
        static Random rnd = new Random();

        private static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            int numero;
            bool isCorrect;
            do
            {
                Console.WriteLine(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0!");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!isCorrect);
            return numero;
        }

        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {

                Console.WriteLine(vettore[i]);
            }
        }

        private static void CaricaVettore(int[] vettore1)
        {
            for (int i = 0; i < vettore1.Length; i++)
            {
                vettore1[i] = rnd.Next(100);
            }
        }

        private static bool IsOrdered(int[] vettore)
        {
            int i = 0;
            bool IsOrdered = false;

            do
            {
                if (vettore[i] < vettore[i + 1])
                {
                    IsOrdered = true;
                    i++;
                }
                else
                {
                    IsOrdered = false;
                }

            } while (IsOrdered && i != vettore.Length - 1);

            return IsOrdered;
        }

        static void Main(string[] args)
        {
            int DimensioneVet;

            DimensioneVet = LeggiNumero("Inserisci la dimensione del vettore: ");
            Console.Clear();

            int[] vet = new int[DimensioneVet];

            CaricaVettore(vet);
            StampaVettore(vet);

            if (IsOrdered(vet))
            {
                Console.WriteLine("Il vettore è ordinato");
            }
            else
            {
                Console.WriteLine("Il vettore è disordinato");
            }

            Console.ReadKey();
        }
    }
}
