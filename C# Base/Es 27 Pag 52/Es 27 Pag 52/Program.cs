using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Es27pag._52
{
    internal class Program
    {

        static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            bool isCorrect = false;
            int numero;

            do
            {
                Console.Write(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                    Console.Write("Devi inserire un numero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!isCorrect);

            return numero;
        }
        static void Main(string[] args)
        {
            int nDec, resto, numero;
            string nBinario = "";

            nDec = LeggiNumero("Inserisci il numero da convertire in decimale: ");
            numero = nDec;

            while (numero > 0)
            {
                resto = numero % 2;
                nBinario = resto + nBinario;
                numero = numero / 2;
            }

            Console.WriteLine($"Il numero {nDec} in binario vale: {nBinario}");
            Console.ReadKey();
        }
    }
}
