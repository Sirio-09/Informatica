using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_9_Pag_115
{
    internal class Program
    {
        static int ContaStudenti(string[] vCitta, int n, string target)
        {
            int contatore = 0;
            bool trovato = false;

            for (int i = 0; i < n; i++)
            {

                if (vCitta[i] == target)
                {
                    contatore++;
                    trovato = true;
                }
                else
                {
                    if (trovato == true)
                    {
                        return contatore;
                    }
                }
            }

            return contatore;
        }

        static void Main()
        {
            string[] studenti = { "Anna", "Beppe", "Carlo", "Dario", "Elena" };
            string[] citta = { "Asti", "Milano", "Milano", "Roma", "Torino" };

            int n = citta.Length;

            Console.Write("Inserisci la città (esatta): ");
            string cittaCercata = Console.ReadLine();

            
            int numeroStudenti = ContaStudenti(citta, n, cittaCercata);

            Console.WriteLine("Studenti trovati a " + cittaCercata + ": " + numeroStudenti);
        }
    }
}
