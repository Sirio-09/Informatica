using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Es_47_Pag_85
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

        private static bool ConfrontaDiagonali(int[,] A, int[,] B)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, i] != B[i, i])
                {
                    return false;
                }
            }
            return true;
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

        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserisci l'ordine (r) delle matrici quadrate: ");

            int[,] A = new int[r, r];
            int[,] B = new int[r, r];

            RiempiMatrice(A);
            RiempiMatrice(B);

            Console.WriteLine("\nMatrice A:");
            StampaMatrice(A);

            Console.WriteLine("\nMatrice B:");
            StampaMatrice(B);

            if (ConfrontaDiagonali(A, B))
            {
                Console.WriteLine("\nRisultato: Le diagonali principali sono UGUALI.");
            }
            else
            {
                Console.WriteLine("\nRisultato: Le diagonali principali sono DIVERSE.");
            }
        }
    }
}

