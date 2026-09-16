using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>

        private static int LeggiNumero(string messaggio)
        {
            bool isCorrect = true;
            int n;

            do
            {
                Console.Write(messaggio);

                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Clear();

                    if (n > 0)
                    {
                        isCorrect = false;
                    }
                    else
                    {
                        Console.WriteLine("Il numero deve essere maggiore di 0!");
                        isCorrect = true;
                    }
                }

            } while (isCorrect);

            return n;
        }

        private static int LeggiNumeroSwitch(string messaggio)
        {
            bool isCorrect = true;
            int n;

            do
            {
                Console.Write(messaggio);

                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Clear();

                    if (n >= 0)
                    {
                        isCorrect = false;
                    }
                    else
                    {
                        Console.WriteLine("Il numero deve essere maggiore o uguale di 0!");
                        isCorrect = true;
                    }
                }

            } while (isCorrect);

            return n;
        }


        private static void RiempiVettore(int[] vet)
        {
            Random rnd = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                int randomNumber;
                bool isDuplicate;
                do
                {
                    randomNumber = rnd.Next(10);
                    isDuplicate = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (vet[j] == randomNumber)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                } while (isDuplicate);

                vet[i] = randomNumber;
            }
        }

        private static void StampaVettore(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        private static void IntersezioneVettore(int[] vet_1, int[] vet_2)
        {
            int temp;

            Console.Write("Risultato Intersezione: ");

            for (int i = 0; i < vet_1.Length; i++)
            {                
                for (int j = 0; j < vet_2.Length; j++)
                {
                    temp = vet_1[i];

                    if (temp == vet_2[j])
                    {
                        Console.Write(vet_1[i] + " ");
                    }              
                }
            }
        }

        private static bool ContieneElemento(int[] vet, int elemento, int lunghezzaVet)
        {
            for (int i = 0; i < lunghezzaVet; i++)
            {
                if (vet[i] == elemento)
                {
                    return true;
                }
            }
            return false;
        }

        private static void UnioneVettore(int[] vet_1, int[] vet_2)
        {
            int dimMax = vet_1.Length + vet_2.Length;
            int[] unioneRes = new int[dimMax];
            int iRes = 0;

            for (int i = 0; i < vet_1.Length; i++)
            {
                unioneRes[iRes] = vet_1[i];
                iRes++;
            }

            for (int j = 0; j < vet_2.Length; j++)
            {
                int elementoCorrente = vet_2[j];

                if (!ContieneElemento(vet_1, elementoCorrente, vet_1.Length))
                {
                    unioneRes[iRes] = elementoCorrente;
                    iRes++;
                }
            }

            Console.Write("Risultato Unione: ");
            for (int i = 0; i < iRes; i++)
            {
                Console.Write(unioneRes[i] + " ");
            }
        }

        private static void DifferenzaVettori(int[] vet1, int[] vet2)
        { 
            int sommaVet1 = 0;

            for (int i = 0; i < vet1.Length; i++)
            {
                sommaVet1 += vet1[i];
            }

            int sommaVet2 = 0;

            for (int i = 0; i < vet2.Length; i++)
            {
                sommaVet2 += vet2[i];
            }

            int res = sommaVet1 - sommaVet2;

            Console.WriteLine("La differenza fra i vettori è di: " + res);

        }

        private static bool VettoriUguali(int[] vet1, int[] vet2)
        {
            int temp;
            bool isEqual = false;

            for (int i = 0; i < vet1.Length; i++)
            {
                temp = vet1[i];

                for (int j = 0; j < vet2.Length; j++)
                {
                    if (temp == vet2[j])
                    {
                        isEqual = true;
                    }
                    else
                    {
                        isEqual = false;
                    }
                }
            }

            return isEqual;
        }

        public static void Main(string[] args)
        {
            int lenghtVet_1;
            int lenghtVet_2;

            lenghtVet_1 = LeggiNumero("Inserisci la dimensione del primo vettore: ");
            lenghtVet_2 = LeggiNumero("Inserisci la dimensione del secondo vettore: ");

            int[] vet_1 = new int[lenghtVet_1];
            int[] vet_2 = new int[lenghtVet_2];

            RiempiVettore(vet_1);
            RiempiVettore(vet_2);


            int nMenu = 1;

            while (nMenu == 1 || nMenu == 2 || nMenu == 3 || nMenu == 4)
            {
                

                Console.WriteLine("1: Intersezione fra vettori\n2: Unione di vettori\n3: Differenza fra vettori\n4: Vettore 1 contenuto nel vettore 2\n(Inserisci qualsiasi altro numero per uscire)");

                nMenu = LeggiNumeroSwitch("--Seleziona la funzione da svolgere: ");

                switch (nMenu)
                {

                    case 1:
                        Console.Write("Vettore 1: ");
                        StampaVettore(vet_1);

                        Console.Write("\nVettore 2: ");
                        StampaVettore(vet_2);

                        Console.WriteLine();
                        IntersezioneVettore(vet_1, vet_2);

                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        Console.Write("Vettore 1: ");
                        StampaVettore(vet_1);

                        Console.Write("\nVettore 2: ");
                        StampaVettore(vet_2);

                        Console.WriteLine();
                        UnioneVettore(vet_1, vet_2);

                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 3:
                        Console.Write("Vettore 1: ");
                        StampaVettore(vet_1);

                        Console.Write("\nVettore 2: ");
                        StampaVettore(vet_2);

                        Console.WriteLine();
                        DifferenzaVettori(vet_1, vet_2);

                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 4:
                        Console.Write("Vettore 1: ");
                        StampaVettore(vet_1);

                        Console.Write("\nVettore 2: ");
                        StampaVettore(vet_2);

                        Console.WriteLine();

                        if (VettoriUguali(vet_1, vet_2))
                        {
                            Console.WriteLine("Il vettore 1 è contenuto nel vettore 2");
                        }
                        else
                        {
                            Console.WriteLine("Il vettore 1 non è contenuto nel vettore 2");
                        }
                        Console.ReadKey();
                        Console.Clear();

                        break;


                }
            }
        }
    }
}
