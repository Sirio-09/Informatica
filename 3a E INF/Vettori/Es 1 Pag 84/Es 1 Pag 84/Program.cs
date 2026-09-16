using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Es_1_Pag_84
{
    internal class Program
    {

        static Random rnd = new Random();

        static int LeggiNumero(string messaggio)
        {
            bool isCorrect = false;
            int numero;

            do
            {
                Console.Write(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero");
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero maggiore di 0!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return numero;
        }

        private static void CaricaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                vettore[i] = rnd.Next(100);
            }
        }
        private static void CopiaVettore(int[] vettore1, int[] vettore2)
        {
            for (int i = 0; i < vettore1.Length; i++)
            {
                vettore2[i] = vettore1[i];
            }
        }

        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {

                Console.WriteLine(vettore[i]);
            }
        }
        static void Main(string[] args)
        {
            int lunghgezzaVet = LeggiNumero("Inserisci la dimensione del Vettore: ");

            int[] vettoreSorgente = new int[lunghgezzaVet];
            int[] vettoreDestinazione = new int[lunghgezzaVet];

            CaricaVettore(vettoreSorgente);
            Console.WriteLine("Vettore prima della copia: ");
            StampaVettore(vettoreSorgente);

            CopiaVettore(vettoreSorgente, vettoreDestinazione);
            Console.WriteLine("Vettore dopo la copia: ");
            StampaVettore(vettoreDestinazione);

            Console.ReadKey();
        }
    }
}