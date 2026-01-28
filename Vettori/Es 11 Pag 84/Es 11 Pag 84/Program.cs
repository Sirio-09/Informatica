using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_11_Pag_84
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

                Console.Write(vettore[i] + " ");
            }
        }


        private static void CaricaVettore(int[] vettore, char tipologia = 'n')
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                switch (tipologia)
                {
                    case 'n':
                        vettore[i] = rnd.Next(10);
                        break;

                    case 'p':
                        vettore[i] = rnd.Next(99) + 1;
                        break;

                    case 'z':
                        vettore[i] = rnd.Next(200) - 99;
                        break;
                }
            }

        }

        private static void CopiaElementiUguali(int[] vetA, int[] vetB, int[] vetC)
        {
            int j = 0;

            for (int i = 0; i < vetA.Length; i++)
            {
                if (vetA[i] == vetB[i])
                {
                    vetA[i] = vetC[j];
                    j++;
                }
            }
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserisci la dimensione del vettore: ");

            int[] vetA = new int[n];
            int[] vetB = new int[n];
            int[] vetC = new int[n];

            CaricaVettore(vetA, 'p');
            CaricaVettore(vetB, 'p');

            Console.WriteLine("\nVettore A: ");
            StampaVettore(vetA);
            Console.WriteLine("\nVettore B: ");
            StampaVettore(vetB);

            Console.WriteLine("\nVettore C: ");
            CopiaElementiUguali(vetA, vetB, vetC);
            StampaVettore(vetC);

            Console.ReadKey();

        }
    }
}
