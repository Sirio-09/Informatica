using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_Verifica_2_TEORIA__Es_3_
{
    internal class Program
    {
        private static int LeggiNumero(string messaggio)
        {
            int n;
            bool isCorrect = false;

            do
            {
                Console.WriteLine(messaggio);

                int.TryParse(Console.ReadLine(), out n);

                if (n < 3)
                {
                    Console.WriteLine("ERRORE: Valore non valido!\nLunghezza Minima Richiesta: 3!");
                    isCorrect = false;
                }
                else
                {
                    isCorrect = true;
                }

            } while (!isCorrect);

            return n;
        }

        private static void CercaEStampa(string[] vet, string nome)
        {
            int[] pos = new int[vet.Length];
            int j = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == nome)
                {
                    pos[j] = i;
                    j++;
                }
            }
            if(j > 0)
            {
                Console.WriteLine(nome + " trovato nella/e posizione/i: ");
                Array.Resize(ref pos, j);
                StampaVettore(pos);
            }
            else
            {
                Console.WriteLine(nome + " non troavato!");
            }
        }

        private static void StampaVettore(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            string[] vet = { "Paola", "Roberto", "Chiara", "Paola", "Giuseppe", "Chiara", "Giorgia", "Maurizio", "Mimmo", "Giacomo" };

            Console.WriteLine("Inserire il nome da Cercare: ");
            string nome = Console.ReadLine();

            CercaEStampa(vet, nome);

            Console.ReadKey();

        }
    }
}
