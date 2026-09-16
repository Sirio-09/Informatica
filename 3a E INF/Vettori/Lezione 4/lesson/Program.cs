using System.Data;
using System.Runtime.Serialization.Formatters;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        /// 

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

            } while(isCorrect);

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
                vet[i] = rnd.Next(100);
            }
        }

        private static void StampaVettore(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        private static void StampaVettorePari(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                }
            }
        }

        private static void StampaVettoreDispari(int[] vet)
        {
            int lastN = -1;

            for (int i = vet.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    lastN = i;
                    break;
                }
            }

            for (int i = 0; i < vet.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(vet[i]);
                    
                    if (i != lastN)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }

        private static void InvertiArray(int[] vet)
        {
            int start = 0;
            int finish = vet.Length - 1;

            while (start < finish)
            {
                int temp = vet[start];
                vet [start] = vet[finish];
                vet [finish] = temp;

                start++;
                finish--;
            }
        }

        private static bool IsOrdered(int[] vet, out bool isOrderedCresc, out bool isOrderedDec)
        {
            isOrderedCresc = true;
            isOrderedDec = true;

            if (vet.Length <= 1)
            {
                isOrderedCresc = true;
                isOrderedDec = true;
                return true;
            }

            for (int i = 0; i < vet.Length - 1; i++)
            {
                if (vet[i] > vet[i + 1])
                {
                    isOrderedCresc = false;
                }

                if (vet[i] < vet[i + 1])
                {
                    isOrderedDec = false;
                }

                if (!isOrderedCresc && !isOrderedDec)
                {
                    return false;
                }
            }

            return isOrderedCresc || isOrderedDec;
        }

        private static void ContaVettore(int[] vet, int n)
        {
            int count = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == n)
                {
                    count++;
                }
            }

            if ( count != 1)
            {
                Console.Write("Il valore " + n + " è presente " + count + " volte");
            }
            else
            {
                Console.Write("Il valore " + n + " è presente " + count + " volta");
            }
            
        }

        public static void Main(string[] args)
        {
            int lenghtVet;

            lenghtVet = LeggiNumero("Inserisci la lunghezza del vettore: ");

            int[] vet = new int[lenghtVet];
            RiempiVettore(vet);

            Console.WriteLine("1: Stampa vettore \n2: Stampa vettore con indice pari \n3: Stampa vettore con indice dispari \n4: Stampa vettore inverso \n5: Verifica se gli elementi del vettore sono ordinati \n6: Conta quante volte è presente un valore nel vettore \n--Inserire qualsiasi altro numero per terminare il programma--");

            int nMenu = LeggiNumeroSwitch("Seleziona la funzione da svolgere: ");
            if (nMenu >= 0)
            {
                switch (nMenu)
                {
                    case 1:
                        StampaVettore(vet);
                        break;

                    case 2:
                        StampaVettorePari(vet);
                        break;

                    case 3:
                        if (lenghtVet == 1)
                        {
                            Console.WriteLine("Il vettore non contiene numeri con indice dispari");
                        }
                        else
                        {
                            StampaVettoreDispari(vet);
                        }
                        break;

                    case 4:
                        InvertiArray(vet);
                        StampaVettore(vet);
                        break;

                    case 5:
                        bool isOrderedCresc;
                        bool isOrderedDec;

                        if (IsOrdered(vet, out isOrderedCresc, out isOrderedDec))
                        {
                            if (lenghtVet == 1)
                            {
                                Console.Write("Il vettore ha solo un elemento");
                            }
                            else
                            {
                                if (isOrderedCresc)
                                {
                                    Console.Write("Il vettore è ordinato in modo crescente");
                                }
                                else if (isOrderedDec)
                                {
                                    Console.Write("Il vettore è ordinato in modo decrescente");
                                }
                            }
                        }
                        else
                        {
                            Console.Write("Il vettore non è ordinato");
                        }
                        break;

                    case 6:
                        int n = LeggiNumero("Inserisci un valore: ");
                        ContaVettore(vet, n);
                        break;

                    default:
                        break;
                }                                          
            }
            else
            {
                return;
            }
        }                                  
    }
}
