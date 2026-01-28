using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Es_34_Pag_85
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

        private static int ContaMatrice(int[,] matrix, int x)
        {
            int count = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0;j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == x)
                    {
                        count++;
                    }
                }
            }

            return count;
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

            int x = LeggiNumero("Inserisci un numero da contare: ");

            int count = ContaMatrice(matrix, x);

            Console.WriteLine("Il numero " + x + " è stato trovato " + count + " volte");

            Console.ReadKey();
        }
    }
}
