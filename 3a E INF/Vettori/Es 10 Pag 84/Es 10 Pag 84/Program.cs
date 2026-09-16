using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_10_Pag_84
{
    internal class Program
    {
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

        private static void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {

                Console.Write(vettore[i] + " ");
            }
        }


        private static void CaricaVettore(int[] vettore, char tipologia = 'n')
        {
            Random rnd = new Random();

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

        private static bool UguaglianzaVettore(int[] vettore)
        {
            bool isEqual = false;
            int i = 0;

            while (vettore[i] == vettore[i + 1] && i < vettore.Length - 1)
            {
                if (vettore[i] == vettore[i + 1])
                {
                    isEqual = true;
                }
                i++;
            }

            return isEqual;
        }

        static void Main(string[] args)
        {
            int dimensioneVettore;

            dimensioneVettore = LeggiNumero("Inserisci la dimensione del vettore: ");

            int[] vet = new int[dimensioneVettore];

            CaricaVettore(vet, 'n');
            StampaVettore(vet);

            if (UguaglianzaVettore(vet))
            {
                Console.WriteLine("\nTutti gli elementi del vettore sono uguali");
            }
            else
            {
                Console.WriteLine("\nGli elementi del vettore NON sono tutti uguali");
            }

            Console.ReadKey();
        }
    }
}
