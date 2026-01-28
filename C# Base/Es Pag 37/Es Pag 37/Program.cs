using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Pag_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int giorno = 0; 
            string mese = string.Empty;

            do
            {
                Console.WriteLine("Inserire un numero fra 1 e 365");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n < 1 || n > 365);

            switch (n)
            {
                case var _ when n < 32:

                    giorno = n;
                    mese = "Gennaio";
                    break;

                case var _ when n < 60:

                    giorno = n - 31;
                    mese = "Febbraio";
                    break;

                case var _ when n < 91:

                    giorno = n - 59;
                    mese = "Marzo";
                    break;

                case var _ when n < 121:

                    giorno = n - 90;
                    mese = "Aprile";
                    break;

                case var _ when n < 152:

                    giorno = n - 120;
                    mese = "Maggio";
                    break;

                case var _ when n < 182:

                    giorno = n - 151;
                    mese = "Giugno";
                    break;

                case var _ when n < 213:

                    giorno = n - 181;
                    mese = "Luglio";
                    break;

                case var _ when n < 244:

                    giorno = n - 212;
                    mese = "Agosto";
                    break;

                case var _ when n < 274:

                    giorno = n - 243;
                    mese = "Settembre";
                    break;

                case var _ when n < 305:

                    giorno = n - 273;
                    mese = "Ottobre";
                    break;

                case var _ when n < 335:

                    giorno = n - 304;
                    mese = "Novembre";
                    break;

                case var _ when n < 366:

                    giorno = n - 334;
                    mese = "Dicembre";                      
                    break;

            }

            Console.WriteLine("Il giorno è " + giorno);
            Console.WriteLine("Il mese è " + mese);

            Console.ReadKey();

        }
    }
}