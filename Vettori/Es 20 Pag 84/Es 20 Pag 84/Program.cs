using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_20_Pag_84
{
    internal class Program
    {
        static void StampaVettore(int[] vettore)
        {
            Console.WriteLine("\nContenuto del vettore:");
            for (int i = 0; i < vettore.Length; i++)
                Console.WriteLine($"Elemento {i + 1}: {vettore[i]}");
        }

        public static bool CercaRipetizioni(int[] vettore)
        {
            bool duplicato = false;

            for (int i = 0;i < vettore.Length && duplicato == false;i++)
            {
                
                for (int j = i + 1; j < vettore.Length && duplicato == false; j++)
                {
                    if (vettore[j] == vettore[i] )
                    {
                        duplicato = true;
                        
                    }
                }
            }
            return duplicato;
            
        }

        static void Main(string[] args)
        {
            int[] vettore = {12, 45, 12, 7, 89, 45, 33, 7, 7, 91,56, 12, 78, 45, 22, 91, 33, 12, 56, 78,45, 7, 12, 33, 89, 22, 56, 91, 45, 12,33, 7, 78, 22, 56, 12, 45, 91, 33, 7,56, 22, 78, 45, 33, 7, 12 };

            StampaVettore(vettore);
            Console.WriteLine();

            if (CercaRipetizioni(vettore) == true)
            {
                Console.WriteLine("Il vettore contriene ripetizioni");
            }
            else
            {
                Console.WriteLine("Il vettore non conteine ripetizioni");
            }
            
        }
    }
}
