using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_4_Pag_115
{
    internal class Program
    {
        public static void OrdinaVettore(string[] vet)
        {
            int i = 0;
            bool scambio;

            do
            {
                scambio = false;

                for (int j = 0; j < vet.Length - 1; j++)
                {
                    if (vet[j].CompareTo(vet[j + 1]) > 0)
                    {
                        string aus = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aus;

                        scambio = true;
                    }
                }

                i++;
            } while (scambio && i < vet.Length);
        }

        public static void StampaVettore(string[] vet)
        {
            for(int i = 0; i <  vet.Length; i++)
            {
                Console.Write(vet[i] + "\n");
            }

            Console.WriteLine();
        }

        public static void TrovaNome(string[] vet, string search, out int indice)
        {
            indice = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                if(vet[i] == search)
                {
                    break;
                }
                indice++;
            }
        }

        static void Main(string[] args)
        {
            string[] nomi = { "Mimmo Falcone", "Silvio Perterrone", "Fausto Letame", "Goffredo Pignatta", "Claudio Bisio", "Mirtillo Fragola", "Felice Cavallo", "Aldo Moro" };

            StampaVettore(nomi);

            OrdinaVettore(nomi);

            StampaVettore(nomi);

            string nome = Console.ReadLine();

            int indice = 0;
            TrovaNome(nomi, nome, out indice);

            Console.WriteLine("Nome trovato alla posizione: " + indice);

            Console.ReadKey();
        }
    }
}
