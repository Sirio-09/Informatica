using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_28_Pag_53
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Inserisci il codice binario: ");

   
            string binario = Console.ReadLine();

       
            long res = 0;

            long potenzaDiDue = 1;

        
            for (int i = binario.Length - 1; i >= 0; i--)
            {
                char cifra = binario[i];

                if (cifra != '0' && cifra != '1')
                {
                    Console.WriteLine($"\nERRORE");
                    Console.ReadKey();
                    return;
                }
   
                if (cifra == '1')
                {
                    res += potenzaDiDue;
                }
            
                potenzaDiDue *= 2;
            }

            Console.WriteLine($"\nIl risultato è: {res}");
            Console.ReadKey();
        }
    }
}