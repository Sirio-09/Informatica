using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_Verifica_TEORIA_2__Es_1_
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

                int.TryParse(Console.ReadLine(), out n );

                if(n < 3)
                {
                    Console.WriteLine("ERRORE: Valore non valido!\nLunghezza Minima Richiesta: 3!");
                    isCorrect = false;
                }
                else
                {
                    isCorrect = true;
                }

            }while(!isCorrect);

            return n;
        }

        private static void CaricaVettore(int[] vet)
        {
            for(int i = 0; i <  vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 50);
            }
        }

        private static void Stampa3Maggiori(int[] vet)
        {
            int count = 0;
            int[] res = new int[3];

            while(count < 3)
            {
                int max = int.MinValue;
                int pos = 0;

                for(int i = 0; i < vet.Length; i++)
                {
                    if(vet[i] > max)
                    {
                        max = vet[i];
                        pos = i;
                    }
                }
                res[count] = max;
                vet[pos] = int.MinValue;

                count++;
            }

            Console.WriteLine("\nI Tre Maggiori Sono: ");
            for(int i = res.Length - 1; i >= 0; i--)
            {

                Console.Write(res[i] + " ");
            }
        }

        

        private static void Stampa3MaggioriNoPariMerito(int[] vet)
        {
            int count = 0;
            int[] res = new int[3];

            while (count < 3)
            {
                int max = int.MinValue;

                for (int i = 0; i < vet.Length; i++)
                {
                    if (vet[i] > max)
                    {
                        max = vet[i];
                    }
                }
                res[count] = max;

                for(int i = 0; i < vet.Length; i++)
                {
                    if (vet[i] == max)
                    {
                        vet[i] = int.MinValue;
                    }
                }

                count++;
            }

            Console.WriteLine("\nI Tre Maggiori Sono (SENZA PARI MERITO)" +
                ": ");
            for (int i = res.Length - 1; i >= 0; i--)
            {

                Console.Write(res[i] + " ");
            }
        }

        private static void StampaVettore(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserisci la lunghezza del vettore: ");

            int[] vet = new int[n];
            int[] vet2 = new int[n];

            CaricaVettore(vet);
            vet.CopyTo(vet2, 0);

            StampaVettore(vet);

            Stampa3Maggiori(vet);

            Stampa3MaggioriNoPariMerito(vet2);

            Console.ReadKey();
        }
    }
}
