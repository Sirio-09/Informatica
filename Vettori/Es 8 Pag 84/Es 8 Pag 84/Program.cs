using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_8_Pag_84
{
    internal class Program
    {
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

        private static void CaricaVettore(int[] vettore1)
        {
            Random rnd = new Random();

            for (int i = 0; i < vettore1.Length; i++)
            {
                vettore1[i] = rnd.Next(100);
            }
        }

        private static void SommaVettore(int[] vettore)
        {
            int sommaPari = 0;
            int sommaDispari = 0;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] % 2 == 0)
                {
                    sommaPari += vettore[i];
                }
                else if (vettore[i] % 2 != 0)
                {
                    sommaDispari += vettore[i];
                }
            }

            Console.WriteLine("\nLa somma dei nueri pari è " + sommaPari);
            Console.WriteLine("La somma dei nueri dispari è " + sommaDispari);
        }

        static void Main(string[] args)
        {
            int dimensioneVettore;

            dimensioneVettore = LeggiNumero("Inserisci la dimensione del vettore: ");

            int[] vet = new int[dimensioneVettore];

            CaricaVettore(vet);
            StampaVettore(vet);

            SommaVettore(vet);

            Console.ReadKey();
        }
    }
}
