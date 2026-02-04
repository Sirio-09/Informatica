using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_15_Pag_115
{
    internal class Program
    {
        static string[] nominativi = new string[]
{
            "Marco Rossi",
            "Luca Bianchi",
            "Andrea Verdi",
            "Paolo Neri",
            "Giovanni Gallo",
            "Matteo Conti",
            "Alessandro Fontana",
            "Davide Ricci",
            "Simone Moretti",
            "Federico Lombardi"
};

        static int[] distanzeCm = new int[]
        {
            642,
            655,
            734,
            671,
            689,
            728,
            702,
            768,
            715,
            751
        };

        private static int[] Cerca3Massimi(int[] vet)
        {
            int i = 0;
            int j = 0;

            int max = 0;
            int[] res = new int[3];

            while (i < 3)
            {
                j = 0;
                while(j < vet.Length)
                {
                    if (vet[j] > max)
                    {
                        max = vet[j];
                    }
                    j++;
                }

                for(int k = 0; k < vet.Length; k++)
                {
                    if(vet[k] == max)
                    {
                        vet[k] = 0;
                    }
                }
                
                res[i] = max;
                max = 0;
                i++;
            }
            return res;
        }

        private static void StampaVettore(int[] vet)
        {
            for(int i = 0; i <  vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            StampaVettore(distanzeCm);
            Console.WriteLine();

            int[] res = new int[3];
            res = Cerca3Massimi(distanzeCm);

            StampaVettore(res);

            Console.WriteLine();
            StampaVettore(distanzeCm);
            



        }
    }
}
