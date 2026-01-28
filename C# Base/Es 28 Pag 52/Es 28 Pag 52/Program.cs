using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_28_Pag_52
{
    internal class Program
    {
        private static bool ControllaBinario(string nBinario)
        {
            for (int i = 0; i < nBinario.Length; i++)
            {
                if (nBinario[i] != '0' && nBinario[i] != '1')
                    return false;
            }
            return true;
        }

        private static int ConvertiBinario(string nBinario)
        {
            int ndecimale = 0;
            int potenza = 1;
            for (int i = nBinario.Length - 1; i >= 0; i--)
            {
                if (nBinario[i] == '1')
                    ndecimale += potenza;

                potenza *= 2;
            }
            return ndecimale;
        }

        static void Main(string[] args)
        {
            string nBinario;

            do
            {
                Console.Write("Inserisci numero binario: ");
                nBinario = Console.ReadLine();
            }
            while (!ControllaBinario(nBinario));

            int risultato = ConvertiBinario(nBinario);
            Console.WriteLine($"Il numero {nBinario} in decimale è {risultato}");

            Console.ReadKey();
        }
    }
}
