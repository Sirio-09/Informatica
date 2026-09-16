using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_43_Pag_85
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

        private static void GeneraMatriceSpirale(int[,] matrix)
        {
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            int top = 0, bottom = r - 1, left = 0, right = c - 1;
            int value = 1;

            while (top <= bottom && left <= right)
            {
                
                for (int i = left; i <= right; i++)
                {
                    matrix[top, i] = value;
                }
                top++;

                
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, right] = value;
                }
                right--;

                if (top <= bottom)
                {
                    
                    for (int i = right; i >= left; i--)
                    {
                        matrix[bottom, i] = value;
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix[i, left] = value;
                    }
                    left++;
                } 
                value++;
            }
        }

        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserisci il numero di righe: ");
            int c = LeggiNumero("Inserisci il numero di colonne: ");

            if (r == c)
            {
                int[,] matrix = new int[r, c];
                GeneraMatriceSpirale(matrix);
                StampaMatrice(matrix);
            }
            else
            {
                Console.WriteLine("La matrice deve essere quadrata!");
            }
        }
    }
}
