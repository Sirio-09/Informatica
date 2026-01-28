using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_8_Pag_115
{
    internal class Program
    {
        static string[] nomi = new string[]
    {
    "Alessandro",
    "Andrea",
    "Federico",
    "Giovanni",
    "Luca",
    "Marco",
    "Matteo",
    "Paolo"
    };


        static string[] cognomi = new string[]
        {
    "Bianchi",
    "Correndo",
    "Esposito",
    "Ferrari",
    "Gallo",
    "Romano",
    "Rossi",
    "Verdi"
        };

        static string[] nomi2 = new string[]
        {
    "Christian",
    "Daniele",
    "Davide",
    "Emanuele",
    "Federico",
    "Gabriele",
    "Nicola",
    "Riccardo",
    "Simone",
    "Stefano"
        };

        static string[] cognomi2 = new string[]
        {
    "Caruso",
    "DeLuca",
    "Fabbri",
    "Lombardi",
    "Marchetti",
    "Moretti",
    "Pellegrini",
    "Rinaldi",
    "Serra",
    "Sorrentino"
        };

        private static void StampaVettore(string[] a)
        {
            for (int i = 0; i <= a.Length; i++)
            {
                if (i == a.Length)
                {
                    break;
                }

                Console.Write(a[i] + " ");
            }
        }

        private static void MergeTappo(string[] a, string[] b, string[] c)
        {
            Array.Resize(ref a, a.Length + 1);
            Array.Resize(ref b, b.Length + 1);

            a[a.Length - 1] = "Zz";
            b[b.Length - 1] = "Zz";

            int i = 0;
            int j = 0;

            for(int k = 0; k < c.Length - 1; k++)
            {
                if (a[i].CompareTo(b[j]) > 0)
                {
                    c[k] = b[j];
                    j++;
                }
                else
                {
                    c[k] = a[i];
                    i++;
                }
            }
        }

        
        static void Main(string[] args)
        {
            string[] names = new string[nomi.Length + nomi2.Length
                ];

            Console.WriteLine("Vettori da unire: ");
            Console.WriteLine("Nomi 1: ");
            StampaVettore(nomi);
            Console.WriteLine();
            Console.WriteLine("Nomi 2: ");
            StampaVettore(nomi2);
            Console.WriteLine("\nNomi Completi: ");
            MergeTappo(nomi, nomi2, names);
            StampaVettore(names);

            Console.WriteLine();

            string[] surname = new string[cognomi.Length + cognomi2.Length];

            Console.WriteLine("Vettori da unire: ");
            Console.WriteLine("Cognomi 1: ");
            StampaVettore(cognomi);
            Console.WriteLine();
            Console.WriteLine("Cognomi 2: ");
            StampaVettore(cognomi2);
            Console.WriteLine("\nCognomi Completi: ");
            MergeTappo(cognomi, cognomi2, surname);
            StampaVettore(surname);
            Console.ReadKey();
        }
    }
}
