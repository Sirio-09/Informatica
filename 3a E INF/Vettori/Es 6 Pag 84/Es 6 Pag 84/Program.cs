using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_6_Pag_84
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

        private static bool IsOrdered(int[] vettore, out bool isCrescente, out bool isDecrescente)
        {
            if (vettore.Length <= 1)
            {
                isCrescente = true;
                isDecrescente = true;
                return true;
            }

            isCrescente = true;
            isDecrescente = true;

            for (int i = 0; i < vettore.Length - 1; i++)
            {
                if (vettore[i] > vettore[i + 1])
                {
                    isCrescente = false;
                }

                if (vettore[i] < vettore[i + 1])
                {
                    isDecrescente = false;
                }

                if (!isCrescente && !isDecrescente)
                {
                    return false;
                }
            }

            return isCrescente || isDecrescente;
        }

        static void Main(string[] args)
        {
            int DimensioneVet;

            DimensioneVet = LeggiNumero("Inserisci la dimensione del vettore: ");
            Console.Clear();

            int[] vet = new int[DimensioneVet];

            CaricaVettore(vet);
            StampaVettore(vet);

            bool ordinatoCrescente;
            bool ordinatoDecrescente;

            if (IsOrdered(vet, out ordinatoCrescente, out ordinatoDecrescente))
            {
                Console.WriteLine("Il vettore è ordinato");

                if (ordinatoCrescente)
                {
                    Console.WriteLine("È in ordine crescente");
                }
                else if (ordinatoDecrescente)
                {
                    Console.WriteLine("È in ordine decrescente");
                }
            }
            else
            {
                Console.WriteLine("Il vettore è disordinato");
            }

            Console.ReadKey();
        }
    }
}
