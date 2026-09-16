using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ricerca_Sequenziale_Caso_4
{
    internal class Program
    {
        private static int RicercaSequenzialeCaso4(string[] vettore, int[] vettorePosizione, string elemento)
        {
            bool trovato = false;
            bool superato = false;
            int i = 0;
            int j = 0;

            while(i < vettore.Length && !superato)
            {
                if (vettore[i] == elemento)
                {
                    vettorePosizione[j] = i;
                    j++;
                }
                else
                {
                    if (elemento.CompareTo(vettore[i]) < 0)
                    {
                        superato = true;
                    }
                }
                i++;
            }

            return j;
        }

        static void Main(string[] args)
        {
            string[] v = { "Bianchi", "Bruni", "Neri", "Pecollo", "Ratti", "Stoppa" };
            int[] vPos  = new int[v.Length];

            string elemento = "Neri";

            int nElementi = RicercaSequenzialeCaso4(v, vPos, elemento);

            Console.WriteLine("Sono stati trovati " + nElementi + " nomi uguali a " + elemento + " nelle posizioni: ");

            for (int i = 0; i < nElementi; i++)
            {
                Console.Write(vPos[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
