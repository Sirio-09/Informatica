using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static bool TrovaNumeriPerfetti(int n)
    {
        int div = 0;
        for (int d = 1; d < n; d++)
        {
            if (n % d == 0)
                div += d;
        }

        return div == n;
    }

    static void Main()
    {
        Console.WriteLine("Numeri perfetti tra 1 e 10000:");
        for (int n = 2; n <= 10000; n++)
        {
            if (TrovaNumeriPerfetti(n))
            {
                Console.WriteLine(n);
            }
        }
        Console.ReadKey();
    }

}