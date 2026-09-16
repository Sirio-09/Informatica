 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args) //Args è un vettore che in c# non ha lunghezza definita
        {
            int ns = 0;
            double prize = 0;

            Console.Write("Inserisci il numero di scatti");
            ns = Convert.ToInt32(Console.ReadLine());

            if (ns >= 0)
            {
                if (ns <= 30)
                {
                    prize = (ns * 0.20) + 2;
                }   
                else if (ns > 30 || ns <= 100)
                {
                    prize = 6 + (ns - 30) * 0.15 + 2.50;
                }
                else
                {
                    prize = 16.50 + (ns - 100) * 0.10 + 2.50;
                }
            }
            else
            {

            }
            Console.WriteLine("Il costo è ", + prize);

        }
    }
}
