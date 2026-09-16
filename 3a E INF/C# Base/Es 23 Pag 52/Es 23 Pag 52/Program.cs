using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_23_Pag_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int nMax;

            Console.WriteLine("Inserire un numero");
            nMax = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            do
            {

                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                    n++;
                }
                else
                {
                    n++;
                }


            } while (n <= nMax);

            Console.ReadLine();
        }
    }
}
