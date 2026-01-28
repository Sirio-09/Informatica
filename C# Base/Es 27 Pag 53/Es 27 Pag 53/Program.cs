using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_27_Pag_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Clear();
                Console.WriteLine("Inserire un numero");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            if (n == 0)
            {
                Console.WriteLine("0");
                return; 
            }
            List<int> res = new List<int>();
            
            while (n > 0)
            {
                res.Add(n % 2);
                n /= 2;
            }

            Console.Write("La rappresentazione binaria è: ");

            for (int i = res.Count - 1; i >= 0; i--)
            {
                Console.Write(res[i]);
            }

            Console.WriteLine(); 
            Console.ReadKey();
        }
    }
}
