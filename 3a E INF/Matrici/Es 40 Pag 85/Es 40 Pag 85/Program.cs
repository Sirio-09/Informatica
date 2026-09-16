using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_40_Pag_85
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
                    matrix[i, j] = rnd.Next(1, 3);
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

        public static bool MatriceSpeculare(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserisci il numero di righe e colonne: ");

            int[,] matrix = new int[r, r];

            RiempiMatrice(matrix);
            Console.WriteLine();
            StampaMatrice(matrix);
            Console.WriteLine();

            if(MatriceSpeculare(matrix) == true)
            {
                Console.WriteLine("La Matrice è Speculare");
            }
            else
            {
                Console.WriteLine("La Matrice non è Speculare");
            }

            Console.ReadKey();
        }
    }
}
