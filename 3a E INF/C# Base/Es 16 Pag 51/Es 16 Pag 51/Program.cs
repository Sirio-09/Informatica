using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_16_Pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            int n1 = rand.Next(1, 6);
            int n2 = rand.Next(1 ,6);
            if (n1 == n2)
            {

                Console.WriteLine("Hai fatto coppia");

            }
            Console.ReadKey();
        }
    }
}
