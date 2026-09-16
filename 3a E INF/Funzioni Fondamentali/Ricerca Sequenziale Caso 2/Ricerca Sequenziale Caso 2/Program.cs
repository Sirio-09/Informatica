using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ricerca_Sequenziale_Caso_2
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

        private static int RicercaSequenziale(string[] vet, string[] v, string nome)
        {
            int count = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == nome)
                {
                    v[i] = nome;
                    count++;
                }
            }

            if (count == 0)
            {
                return -1;
            }

            return count;
        }
        static void Main(string[] args)
        {
            int dim = LeggiNumero("Inserisci la dimesione del vettore: ");

            string[] vet = new string[dim];
            string[] v = new string[dim];

            Console.WriteLine("\nInserisci gli elementi del vettore: ");
            CaricaVettore(vet);

            Console.WriteLine("\nInserisci il nome da cercare: ");
            string nome = Console.ReadLine();

            int count = RicercaSequenziale(vet, v, nome);

            if (count == 0)
            {
                Console.WriteLine(nome + " NON PRESENTE");
            }
            else
            {
                Console.WriteLine("Nome: " + nome + " trovato nelle seguenti posizioni: \n");

                for(int i = 0; i < count; i++)
                {
                    Console.Write(i + " ");
                }
            }
                Console.ReadKey();
        }
    }
}
