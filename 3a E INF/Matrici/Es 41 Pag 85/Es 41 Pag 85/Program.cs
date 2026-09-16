using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Es_41_Pag_85
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

        private static bool IsSpiral(int[,] matrix)
        {
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            int top = 0;
            int bottom = r - 1;
            int right = c - 1;
            int left = 0;

            int value = 1;

            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    if (matrix[top, i] != value++)
                    {
                        return false;
                    }
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    if (matrix[i, right] != value++)
                    {
                        return false;
                    }
                }
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        if (matrix[bottom, i] != value++)
                        {
                            return false;
                        }
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        if (matrix[i, left] != value++)
                        {
                            return false;
                        }
                    }
                    left++;
                }

            }
            return true;
        }

        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserisci il numero di righe: ");
            int c = LeggiNumero("Inserisci il numero di colonne: ");

            if(r == c)
            {
                int[,] matrix = new int[r, c];
                RiempiMatrice(matrix);
                StampaMatrice(matrix);

                if (IsSpiral(matrix))
                {
                    Console.WriteLine("La matrice è a spirale!");
                }
                else
                {
                    Console.WriteLine("La matrice non è a spirale!");
                }
            }
            else
            {
                Console.WriteLine("Deve essere una matrice quadrata!");
            }
        }
    }
}
