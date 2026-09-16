using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricerca_Sequenziale_Caso_3
{
    internal class Program
    {
        private static int RicercaSequenziale(string[] vettore, string nome)
        {
            int i = 0;

            while(i < vettore.Length && nome.CompareTo(vettore[i]) > 0)
            {
                i++;
            }
            if (vettore[i] == nome)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
        
        static void Main(string[] args)
        {
            const string elemento = "Gallo";

            string[] v = new string[]
                {"Bianchi", "Gallo", "Rossi", "Malendri", "Napoli", "Olocco", "Taricco"};

            int pos = RicercaSequenziale(v, elemento);

            if (RicercaSequenziale(v, elemento) >= 0)
            {
                Console.WriteLine("Nome: " + elemento + " Trovato in posizione " + pos);
            }
            else
            {
                Console.WriteLine(elemento + " non presente nel vettore");
            }
        }
    }
}
