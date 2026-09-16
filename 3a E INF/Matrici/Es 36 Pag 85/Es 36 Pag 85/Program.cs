using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_36_Pag_85
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

        private static bool SommaDiagonaliMatrice(int[,] matrix)
        {
            int sum1 = 0;
            int sum2 = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                sum1 += matrix[i, i];
                sum2 += matrix[i, matrix.GetLength(0) - 1 - i];
            }

            return sum1 == sum2;
        }

        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserisci il numero di righe e colonne: ");

            int[,] matrix = new int[r, r];

            RiempiMatrice(matrix);
            Console.WriteLine();
            StampaMatrice(matrix);
            Console.WriteLine();

            if (SommaDiagonaliMatrice(matrix))
            {
                Console.WriteLine("La Somma delle Diagonali è Uguale");
            }
            else
            {
                Console.WriteLine("La Somma delle Diagonali non è Uguale");
            }

            Console.ReadKey();
        }
    }
}
