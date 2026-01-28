using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_17_Pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var rand = new Random();

            int n1 = rand.Next(1, 5);
            int n2 = rand.Next(1, 5);
            int n3 = rand.Next(1, 5);

            if (n1 == n2 && n2 == n3)
            {

                Console.WriteLine("Hai fatto tris");

                Console.ReadKey();

                return;
            }

            if (n1 == n2 || n2 == n3 || n1 == n3)
            {

                Console.WriteLine("Hai fatto coppia");

                Console.ReadKey();

                return;
            }
        }
    }
}
