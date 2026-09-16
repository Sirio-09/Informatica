using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_Verifica_2_TEORIA__Es_2_
{
    internal class Program
    {
        static Random rnd = new Random();

        private static int LeggiNumero(string messaggio)
        {
            int n;
            bool isCorrect = false;

            do
            {
                Console.WriteLine(messaggio);

                int.TryParse(Console.ReadLine(), out n);

                if (n < 3)
                {
                    Console.WriteLine("ERRORE: Valore non valido!\nLunghezza Minima Richiesta: 3!");
                    isCorrect = false;
                }
                else
                {
                    isCorrect = true;
                }

            } while (!isCorrect);

            return n;
        }

        private static void CaricaVettore(int[] vet, int lenght)
        {
            int i = 0;

            while (i < vet.Length)
            {
                int newNumber = rnd.Next(1, 11);

                bool duplicato = false;

                for (int j = 0; j < lenght; j++)
                {

                    if (newNumber == vet[j])
                    {
                        duplicato = true;
                        break;
                    }
                }

                if (!duplicato)
                {
                    vet[i] = newNumber;
                    i++;
                }
            } 

        }

        private static void StampaVettore(int[] vet)
        {
            for(int i = 0;i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserisci la dimensione del vettore: ");
            int[] vet = new int[n];

            CaricaVettore(vet, n);
            StampaVettore(vet);

            Console.ReadKey();
        }
    }
}
