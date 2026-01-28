using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_12_Pag_84
{
    internal class Program
    {
        static Random rnd = new Random();

        private static void CaricaVettore(int[] vettore, char tipologia = 'n')
        {        
            for (int i = 0; i < vettore.Length; i++)
            {
                switch (tipologia)
                {
                    case 'n':
                        vettore[i] = rnd.Next(10);
                        break;

                    case 'p':
                        vettore[i] = rnd.Next(99) + 1;
                        break;

                    case 'z':
                        vettore[i] = rnd.Next(200) - 99;
                        break;
                }
            }
        }

        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {

                Console.Write(vettore[i] + " ");
            }
        }

        private static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            int numero;
            bool isCorrect;
            do
            {
                Console.WriteLine(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0!");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!isCorrect);
            return numero;
        }

        private static int MediaVettore(int[] vet1)
        {
            int somma1 = 0;
            int i;

            for (i = 0; i < vet1.Length; i++)
            {
                somma1 += vet1[i];
            }

            return somma1 / i;
        }

        static void Main(string[] args)
        {
            int dimVet1 = LeggiNumero("Inserisci la dimensione del primo vettore: ");
            int dimVet2 = LeggiNumero("Inserisci la dimensione del secondo vettore: ");

            int[] vet1 = new int[dimVet1];
            int[] vet2 = new int[dimVet2];

            CaricaVettore(vet1, 'n');
            
            CaricaVettore(vet2, 'n');

            Console.WriteLine("Vettore 1: ");
            StampaVettore(vet1);
            Console.WriteLine("\nVettore 2: ");
            StampaVettore(vet2);

            int media1 = MediaVettore(vet1);
            int media2 = MediaVettore(vet2);

            Console.WriteLine("\nLa media del primo vettore è: " + media1);
            Console.WriteLine("La media del secondo vettore è: " + media2);

            if (media1 == media2)
            {
                Console.WriteLine("Le due medie sono uguali");
            }
            else
            {
                Console.WriteLine("Le due medie sono diverse");
            }



        }
    }
}
