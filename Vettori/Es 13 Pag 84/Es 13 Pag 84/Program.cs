using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_13_Pag_84
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

        private static bool IsSpecular(int[] vet)
        {
            for (int i = 0; i < vet.Length / 2; i++)
            {
                if (vet[i] != vet[vet.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        private static void CaricaVet(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                do
                {
                    int j = i + 1;
                    Console.Write("Inserisci il " + j + "o elemento: ");
                    vet[i] = Convert.ToInt32(Console.ReadLine());
                    
                    if(vet[i] < 0)
                    {
                        Console.WriteLine("Il numero deve essere positivo!\n");
                    }

                } while (vet[i] < 0);           
            }
        }

        static void Main(string[] args)
        {
            int dim = LeggiNumero("Inserisci la lunghezza del Vettore: ");
            int[] vet = new int[dim];

            CaricaVet(vet);

            Console.WriteLine("Vettore: ");
            StampaVettore(vet);

            if (IsSpecular(vet))
            {
                Console.WriteLine("\nIl vettore è speculare");
            }
            else
            {
                Console.WriteLine("\nIl vettore non è speculare");
            }

        }
    }
}
