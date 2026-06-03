using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_1_Es_B
{
    internal class ContoBancario
    {
        private string numeroConto;
        private double saldo;

        public ContoBancario(string numeroConto, double saldoIniziale)
        {
            this.numeroConto = numeroConto;
            this.Saldo = saldoIniziale;
        }

        public string NumeroConto
        {
            get { return numeroConto; }
        }

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                    saldo = value;
                else
                    Console.WriteLine("Errore: il saldo non può essere negativo.");
            }
        }

        public void Deposita(double importo)
        {
            if (importo <= 0)
            {
                Console.WriteLine("Errore: l'importo da depositare deve essere maggiore di 0.");
                return;
            }
            saldo += importo;
            Console.WriteLine($"Deposito di €{importo:F2} effettuato. Nuovo saldo: €{saldo:F2}");
        }

        public void Preleva(double importo)
        {
            if (importo <= 0)
            {
                Console.WriteLine("Errore: l'importo da prelevare deve essere maggiore di 0.");
                return;
            }
            if (importo > saldo)
            {
                Console.WriteLine($"Errore: saldo insufficiente. " +
                                  $"Saldo disponibile: €{saldo:F2}, richiesto: €{importo:F2}");
                return;
            }
            saldo -= importo;
            Console.WriteLine($"Prelievo di €{importo:F2} effettuato. Nuovo saldo: €{saldo:F2}");
        }

        public void StampaSaldo()
        {
            Console.WriteLine($"Conto: {NumeroConto}  |  Saldo attuale: €{Saldo:F2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            ContoBancario conto1 = new ContoBancario("IT001-2345-6789", 1000.00);
            conto1.StampaSaldo();

            Console.WriteLine();

            Console.WriteLine("-- Test Deposita --");
            conto1.Deposita(500.00);
            conto1.Deposita(-100.00);
            conto1.Deposita(0);

            Console.WriteLine();

            Console.WriteLine("-- Test Preleva --");
            conto1.Preleva(200.00);
            conto1.Preleva(5000.00);
            conto1.Preleva(-50.00);

            Console.WriteLine();

            Console.WriteLine("-- Test saldo iniziale negativo --");
            ContoBancario conto2 = new ContoBancario("IT002-9999-0000", -500.00);
            conto2.StampaSaldo();

            Console.WriteLine();
            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}