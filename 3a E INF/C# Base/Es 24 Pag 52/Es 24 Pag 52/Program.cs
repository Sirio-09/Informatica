using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_24_Pag_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            do
            {
                Console.Clear();
                Console.WriteLine("Inserisci 2 numeri (n2 > n1)");

                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());              

            } while (n1 > n2);

            Console.Clear();

            do
            {
                if (n1 % 2 == 1)
                {
                    Console.WriteLine(n1);
                    n1++;
                }
                else
                {
                    n1++;
                }

            }while(n1 <= n2);

            Console.ReadLine();
        }
    }
}
