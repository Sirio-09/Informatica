using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_26_Pag_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int res;

            do
            {
                Console.Clear();

                Console.WriteLine("Inserire un numero");
                n = Convert.ToInt32(Console.ReadLine());

            }while (n < 0);

            if (n != 0)
            {
                res = n;

                for (int i = 1; i < n; i++)
                {
                    res = res * i;
                }
                Console.WriteLine("Il risultato è " + res);
            }
            else
            {
                res = 1;
                Console.WriteLine("Il risultato è " + res);
            }

        }
    }
}
