using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricerca_Dicotomica
{
    internal class Program
    {
        private static int RicercaDicotomica(string[] vettore, string nomeDaCercare)
        {
            int posizione = -1;
            int min = 0;
            int max = vettore.Length - 1;
            int meta = 0;
            int i = 0;

            while (min <= max)
            {
                meta = (max + min) / 2;

                if (vettore[meta] == nomeDaCercare)
                {
                    return meta;
                }
                else
                {
                    if (nomeDaCercare.CompareTo(vettore[meta]) > 0)
                    {
                        min = meta + 1;
                    }
                    else
                    {
                        max = meta - 1;
                    }
                }
            }
            

            return posizione;
        }

        static void Main(string[] args)
        {
            string[] v = { "Agosti", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca",
                           "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi",
                           "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };

            string nomeDaCercare = "Conti";

            int pos = RicercaDicotomica(v, nomeDaCercare);

            if(pos == -1)
            {
                Console.WriteLine(nomeDaCercare + " non presente nell'insieme");
            }
            else
            {
                Console.WriteLine(nomeDaCercare + " è stato trovato alla posizione " + pos);
            }
        }
    }
}
