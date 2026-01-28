using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Es_9_Pag_84
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
                        vettore[i] = rnd.Next(100);
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

        private static void ContaPositiviNegativi(int[] vettore , ref int contaPositivi, ref int contaNegativi)
        {
            for(int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] > 0)
                {
                    contaPositivi++;
                }
                else if (vettore[i] < 0)
                {
                    contaNegativi++;
                }
            }
        }

        static void Main(string[] args)
        {
            int dimensioneVettore;

            dimensioneVettore = LeggiNumero("Inserisci la dimensione del vettore: ");

            int[] vet = new int[dimensioneVettore];

            int contaPositivi = 0;
            int contaNegativi = 0;

            CaricaVettore(vet, 'z');
            StampaVettore(vet);

            ContaPositiviNegativi(vet, ref  contaPositivi, ref contaNegativi);

            Console.WriteLine("\n\nNel vettore ci sono " + contaPositivi + " numeri positivi e " + contaNegativi + " numeri negativi");

            Console.ReadKey();
        }
    }
}