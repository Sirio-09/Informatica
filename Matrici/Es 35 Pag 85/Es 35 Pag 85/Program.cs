using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_35_Pag_85
{
    internal class Program
    {
        static Random rnd = new Random();

        private static int LeggiNumero(string mess)
        {
            int n = 0;
            bool isCorrect = false;

            do
            {
                Console.WriteLine(mess);

                int.TryParse(Console.ReadLine(), out n);

                if (n > 0)
                {
                    isCorrect = true;
                }

            } while (!isCorrect);

            return n;
        }

        private static void RiempiMatrice(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }
        }

        private static void StampaMatrice(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int SommaColonna(int j, int[,] matrix)
        {
            int somma = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                somma += matrix[i, j];
            }

            return somma;
        }

        private static int SommaRiga(int i, int[,] matrix)
        {
            int somma = 0;

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                somma += matrix[i, j];
            }

            return somma;
        }

        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserisci il numero di righe e colonne: ");

            int[,] matrix = new int[r, r];

            RiempiMatrice(matrix);
            Console.WriteLine();
            StampaMatrice(matrix);

            int j = LeggiNumero("Inserisci la colonna da calcolare: ");
            int i = LeggiNumero("Inserisci la riga da calcolare: ");

            int sumColonna = SommaColonna(j, matrix);
            int sumRiga = SommaRiga(i, matrix);

            if(sumColonna == sumRiga)
            {
                Console.WriteLine("Somma Colonna: " + sumColonna);
                Console.WriteLine("Somma Riga: " + sumRiga);

                Console.WriteLine("La somma della colonna " + j + " è uguale alla somma della riga " + j);
            }
            else
            {
                Console.WriteLine("Somma Colonna: " + sumColonna);
                Console.WriteLine("Somma Riga: " + sumRiga);

                Console.WriteLine("La somma della colonna " + j + " non è uguale alla somma della riga " + i);
            }
        }
    }
}
