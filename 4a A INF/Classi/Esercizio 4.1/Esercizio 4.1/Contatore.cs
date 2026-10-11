using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_4._1
{
    internal class Contatore
    {
        private int valore;

        private Contatore()
        {
            valore = 0;
        }

        public static Contatore CreaContatore()
        {
            return new Contatore();
        }

        public int Incrementa()
        {
            valore++;
            return valore;
        }

        public int Azzera()
        {
            valore = 0;
            return valore;
        }
    }
}
