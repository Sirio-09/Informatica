using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Es_2_Pag_84
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

        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {

                Console.WriteLine(vettore[i]);
            }
        }

        
        private static void InvertiVettore(int[] vettore)
        {
            int j = vettore.Length - 1;
            int aus;
            
            for (int i = 0; i < (vettore.Length - 1) / 2; ++i)
            {
                aus = vettore[i];
                vettore[i] = vettore[j];
                vettore[j] = aus;
                j--;
            }
        }
        

        static void Main(string[] args)
        {
            int lunghgezzaVet = LeggiNumero("Inserisci la dimensione del Vettore: ");

            int[] vettoreSorgente = new int[lunghgezzaVet];

            CaricaVettore(vettoreSorgente);
            Console.WriteLine("Vettore prima dell'inversione: ");
            StampaVettore(vettoreSorgente);

            InvertiVettore(vettoreSorgente);

            Console.WriteLine("Vettore dopo l'inversione: ");
            StampaVettore(vettoreSorgente);

            Console.ReadKey();
        }
    }
}