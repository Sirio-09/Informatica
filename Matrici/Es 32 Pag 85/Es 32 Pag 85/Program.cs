using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_32_Pag_85
{
    internal class Program
    {
        static int CalcolaSommaRiga(int[,] A, int rigaScelta)
        {
            int somma = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                somma += A[rigaScelta, j];
            }
            return somma;
        }

        static void StampaMatrice(int[,] A)
        {
            Console.WriteLine("Matrice generata:");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void RiempiMatrice(int[,] A)
        {
            Random generatore = new Random();

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    
                    A[i, j] = generatore.Next(1, 10);
                }
            }
        }

        static void Main()
        {
            int righe = 4;
            int colonne = 5;
            int[,] matrice = new int[righe, colonne];

            RiempiMatrice(matrice);

            StampaMatrice(matrice);

            Console.Write("\nQuale riga vuoi sommare? (0-" + (righe - 1) + "): ");
            int indiceRiga = int.Parse(Console.ReadLine());

            if (indiceRiga >= 0 && indiceRiga < righe)
            {
                int risultato = CalcolaSommaRiga(matrice, indiceRiga);
                Console.WriteLine($"La somma della riga {indiceRiga} è: {risultato}");
            }
            else
            {
                Console.WriteLine("Errore: indice fuori dai limiti!");
            }
        }
        
    }
}
