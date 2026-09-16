using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_16_Pag_115
{
    internal class Program
    {
        static string[] nominativi = new string[]
        {
            "Marco Rossi", "Luca Bianchi", "Andrea Verdi", "Paolo Neri", "Giovanni Gallo",
            "Matteo Conti", "Alessandro Fontana", "Davide Ricci", "Simone Moretti", "Federico Lombardi"
        };

        static int[] distanzeCm = new int[]
        {
            642, 655, 734, 671, 689, 728, 768, 768, 715, 751
        };

        private static int[] Cerca3Massimi(int[] vet)
        {
            int[] copiaVet = (int[])vet.Clone();

            int[] res = new int[3];

            for (int i = 0; i < 3; i++)
            {
                int max = -1;
                int indiceMax = -1;

                for (int j = 0; j < copiaVet.Length; j++)
                {
                    if (copiaVet[j] > max)
                    {
                        max = copiaVet[j];
                        indiceMax = j;
                    }
                }

                if (indiceMax != -1)
                {
                    res[i] = max;
                    copiaVet[indiceMax] = -1;
                }
            }
            return res;
        }

        private static void StampaVettore(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dati originali:");
            StampaVettore(distanzeCm);
            Console.WriteLine();

            int[] res = Cerca3Massimi(distanzeCm);

            Console.WriteLine("I 3 migliori risultati (inclusi pari merito):");
            StampaVettore(res);

            Console.ReadKey();
        }
    }
}
