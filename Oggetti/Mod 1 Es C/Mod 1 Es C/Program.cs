using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_1_Es_C
{
    internal class Persona
    {
        private string nome;
        private string cognome;
        private int eta;

        public Persona(string nome, string cognome, int eta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta;
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Nome), "Il nome non può essere null.");
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Il nome non può essere vuoto.", nameof(Nome));
                nome = value;
            }
        }

        public string Cognome
        {
            get { return cognome; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Cognome), "Il cognome non può essere null.");
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Il cognome non può essere vuoto.", nameof(Cognome));
                cognome = value;
            }
        }

        public int Eta
        {
            get { return eta; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("L'età deve essere maggiore di 0.", nameof(Eta));
                eta = value;
            }
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}, Età: {Eta}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Persona p = new Persona("Alice", "Verdi", 22);
                Console.WriteLine("Oggetto creato: " + p);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine("-- Test età negativa --");
            try
            {
                Persona p = new Persona("Bob", "Neri", -3);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException catturata: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("-- Test nome null --");
            try
            {
                Persona p = new Persona(null, "Bianchi", 20);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException catturata: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("-- Test cognome vuoto --");
            try
            {
                Persona p = new Persona("Carlo", "   ", 28);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException catturata: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("-- Modifica valida --");
            try
            {
                Persona p = new Persona("Diana", "Grigi", 18);
                p.Eta = 19;
                Console.WriteLine("Dopo modifica: " + p);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}