using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Es_44_Pag_85
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

        private static bool MatriceCrescente(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {

                    if (matrix[row, col] >= matrix[row + 1, col])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void RiempiMatrice(int[,] matrix)
        {
            int count = 0;  

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = count++;
                }
            }
        }

        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserisci il numero di righe: ");
            int c = LeggiNumero("Inserisci il numero di colonne: ");

            int[,] matrix = new int[r, c];
            RiempiMatrice(matrix);

            Console.WriteLine();
            StampaMatrice(matrix);
            Console.WriteLine();


            if (MatriceCrescente(matrix))
            {
                Console.WriteLine("La matrice è in ordine crescente!");
            }
            else
            {
                Console.WriteLine("La matrice non è in ordine crescente!");
            }
        }
    }
}
