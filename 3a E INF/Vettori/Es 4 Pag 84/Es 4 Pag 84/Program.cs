using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_4_Pag_84
{
    internal class Program
    {
        static Random rnd = new Random();
        static int maxGlobal, minGlobal;

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

        private static void CaricaVettore(int[] vettore1)
        {
            for (int i = 0; i < vettore1.Length; i++)
{
                vettore1[i] = rnd.Next(100);
            }
        }

        private static void CopiVettore(int[] vettoreSorgente, int[] vettoreDestinazione)
        {
            for (int i = 0; i < vettoreDestinazione.Length; i++)
{
                vettoreDestinazione[i] = vettoreSorgente[i];
            }
        }

        private static void CercaMaxMin(int[] vettore, ref int max, ref int min)
        {
            max = int.MinValue;
            min = int.MaxValue;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (max < vettore[i])
                {
                    max = vettore[i];
                }
                if (min > vettore[i])
                {
                    min = vettore[i];
                }
            }
        }

        private static void CercaMaxMinGlobal(int[] vettore)
        {
            maxGlobal = int.MinValue;
            minGlobal = int.MaxValue;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (maxGlobal < vettore[i])
                {
                    maxGlobal = vettore[i];
                }
                if (minGlobal > vettore[i])
                {
                    minGlobal = vettore[i];
                }
            }

        }

        static void Main(string[] args)
        {
            int lunghezzaVet;
            int max, min;

            lunghezzaVet = LeggiNumero("Inserisci le dimensioni del vettore: ");
            int[] vet = new int[lunghezzaVet];

            max = min = 0;

            CaricaVettore(vet);
            CercaMaxMin(vet, ref max, ref min);
            CercaMaxMinGlobal(vet);

            Console.WriteLine("Passaggio per valore: \nMax: " + max + "\nMin: " + min);
            Console.WriteLine("Passaggio per riferimento: \nMax: " + maxGlobal + "\nMin: " + minGlobal);

            Console.ReadKey();
        }
    }
}
