using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ricerca_Sequenziale
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

        private static void CaricaVettore(string[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Elemento " + i + ": ");
                vet[i] = Console.ReadLine();
            }
        }

        private static int RicercaSequenziale(string[] vet, string nome)
        {
            int i = -1;

            do
            {
                i++;

            } while (vet[i] != nome && i != vet.Length - 1);

            if (vet[i] == nome)
            {
                return i;
            }
            else return -1;

        }

        static void Main(string[] args)
        {
            int dim = LeggiNumero("Inserisci la dimesione del vettore: ");

            string[] vet = new string[dim];

            Console.WriteLine("\nInserisci gli elementi del vettore: ");
            CaricaVettore(vet);

            Console.WriteLine("\nInserisci il nome da cercare: ");
            string nome = Console.ReadLine();

            int res = RicercaSequenziale(vet, nome);

            if (res != -1)
            {
                Console.WriteLine("\nElemento trovato in posizione: " + res);
            }
            else
            {
                Console.WriteLine("\nElemento non trovato");
            }

            Console.ReadKey();
        }
    }
}
