using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_22_Pag_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int nMax = 0;

            do
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                    n++;
                    nMax++;
                }
                else
                {
                    n++;
                }

            } while (nMax < 100);

            Console.ReadKey();
        }
    }
}
