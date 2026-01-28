using System.Data;
using System.Runtime.ExceptionServices;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            try
            {
                char choice = Menu();

                // modificare per fare delle prove
                int[] numbers = { 1, 2, 3, 4, 5 };
                int[] result;
                string[] values = { "Aldo", "Bruno", "Carlo" };
                int N = 2;

                switch (choice)
                {
                    case 'A':
                        int primeCount = Esercizio1(numbers);
                        Console.WriteLine(primeCount);
                        break;
                    case 'B':
                        // modificare per fare delle prove
                        int size = 5;

                        int firstIndex = Esercizio2(values, size);
                        Console.WriteLine(firstIndex);
                        break;
                    case 'C':
                        // modificare per fare delle prove
                        int searchedValue = 15;

                        int searchedIndex = Esercizio3(numbers, searchedValue);
                        Console.WriteLine(searchedIndex);
                        break;
                    case 'D':
                        // esempio per fare delle prove
                        Random rnd = new Random();
                        string[] generatedWords = Esercizio4(rnd, values, N);
                        Console.WriteLine(String.Join(',', generatedWords));
                        break;
                    case 'E':
                        Console.WriteLine($"Array sorgente: ${String.Join(',', numbers)}");
                        result = Esercizio5(numbers);
                        Console.WriteLine($"Array risultato: ${String.Join(',', result)}");
                        break;
                    case 'X':
                        Console.WriteLine("Programma terminato");
                        break;
                    default:
                        throw new Exception("Scelta non valida");
                }

            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"ATTENZIONE: {ex.TargetSite!.Name} non implementato");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ATTENZIONE: {ex.Message}");
            }
        }


        /// <summary>
        /// (1 punti) Crea un menù con le seguenti voci:
        /// A -> Esercizio 1
        /// B -> Esercizio 2
        /// C -> Esercizio 3
        /// D -> Esercizio 4
        /// E -> Esercizio 5
        /// X -> Esci dal programma
        /// </summary>
        /// <returns>
        /// La voce scelta, se corretta.
        /// Se la scelta non è valida, riproporre nuovamente
        /// il menù finché non si sceglie correttamente.
        /// </returns>
        public static char Menu()
        {
            char choice = ' ';
            bool isCorrect = true;

            while (isCorrect)
            {
                Console.WriteLine("A -> Esercizio 1");
                Console.WriteLine("B -> Esercizio 2");
                Console.WriteLine("C -> Esercizio 3");
                Console.WriteLine("D -> Esercizio 4");
                Console.WriteLine("E -> Esercizio 5");
                Console.WriteLine("X -> Esci dal programma");

                choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'A' || choice == 'B' || choice == 'C' || choice == 'D' || choice == 'E')
                {
                    isCorrect = false;
                }
                else if (choice == 'X')
                {
                    break;
                }
                
            }
            return choice;
        }

        /// <summary>
        /// (1,5 punti) Restituisce il numero di numeri primi all'interno dell'array passato come parametro.
        /// Si noti che la soluzione deve essere ottimizzata o i test non passeranno.
        /// </summary>
        /// <param name="numbers">L'array di numeri da considerare per il conteggio</param>
        /// <returns>
        /// Il conteggio dei numeri primi all'interno dell'array passato come parametro.
        /// </returns>
        /// <example>
        /// int[] numbers = { 1, 2, 5, 10 };
        /// Console.WriteLine(esercizio1(numbers)); // 2
        /// </example>
        public static int Esercizio1(int[] numbers)
        {
            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {   
               if (isPrime(numbers, i))
               {
                    count++;
               }
            }
            return count;
        }

        private static bool isPrime(int[] numbers, int i)
        {
            for(int j = 0; i < numbers[i]; j++)
            {
                if (n <= 1)
                {
                    return false;
                }
                if (n <= 3)
                {
                    return true;
                }

                if (n % 2 == 0)
                {
                    return false;
                }

                for (int i = 3; (long)i * i <= n; i += 2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            
        }
    }
}

        /// <summary>
        /// (1 punto) Ricerca la prima occorrenza in un array ORDINATO fornito come parametro di una stringa con 
        /// una dimensione uguale a quella fornita.
        /// </summary>
        /// <param name="values">L'array di valori in cui ricercare</param>
        /// <param name="size">La dimensione da ricercare</param>
        /// <returns>
        /// L'indice della prima occorrenza che rispetta il requisito, -1 se non vi è
        /// nessun elemento che rispetti il requisito.
        /// </returns>
        /// <example>
        /// string[] values = { "Aldo", "Bruno", "Carlo" };
        /// 
        /// Console.WriteLine(esercizio2(values, 4)); // 0;
        /// Console.WriteLine(esercizio2(values, 5)); // 1;
        /// Console.WriteLine(esercizio2(values, 3)); // -1;
        /// </example>
        public static int Esercizio2(string[] values, int size)
        {

            for(int i = 0; i < values.Length; i++)
            {
                if (values[i].Length == size)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// (1,5 punti) Ricerca la prima occorrenza di un numero in un array ORDINATO e SENZA RIPETIZIONI fornito come parametro.
        /// </summary>
        /// <param name="numbers">L'array di valori in cui ricercare</param>
        /// <param name="value">Il valore da ricercare</param>
        /// <returns>
        /// L'indice della prima occorrenza che rispetta il requisito, -1 se non vi è
        /// nessun elemento che rispetti il requisito.
        /// </returns>
        /// <example>
        /// int[] numbers = { 0, 1, 10 };
        /// 
        /// Console.WriteLine(Esercizio3(numbers, 0)); // 0;
        /// Console.WriteLine(Esercizio3(numbers, 1)); // 1;
        /// Console.WriteLine(Esercizio3(numbers, 3)); // -1;
        /// </example>
        public static int Esercizio3(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (value == numbers[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// (1,5 punti) Crea un array di N parole casuali DISTINTE fra quelle specificate nell'array passato come parametro.
        /// Se N >= al numero di elementi di words, creare al massimo N elementi.
        /// </summary>
        /// <param name="rnd">Il generatore di numeri casuali</param>
        /// <param name="words">L'array di parole da cui prendere riferimento</param>
        /// <param name="n">Il numero di parole distinte da generare</param>
        /// <returns>
        /// L'array di stringhe casuali creato.
        /// </returns>
        /// <example>
        /// Random rnd = new Random();
        /// string[] words = { "papo", "pepo", "pupo" };
        /// 
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, words, 1)); // "pupo"
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, words, 1)); // "papo"
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, words, 2)); // "pupo,papo"
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, words, 2)); // "papo,pupo"
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, words, 3)); // "pupo,papo,pepo"
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, words, 4)); // "pupo,pepo,papo"
        /// </example>
        public static string[] Esercizio4(Random rnd, string[] words, int n)
        {
            int wordsToGenerate;
            bool unique;

            if(n > words.Length)
            {
                wordsToGenerate = words.Length;
            }
            else
            {
                wordsToGenerate = n;
            }

            string[] randomWords = new string[wordsToGenerate];

            for (int i = 0; i < wordsToGenerate; i++)
            {
                do
                {
                    int randomIndex = rnd.Next(words.Length);
                    randomWords[i] = words[randomIndex];

                    unique = true;

                    for (int j = 0; i < i; j++)
                    {
                        if (randomWords[i] == randomWords[j])
                        {
                            unique = false;
                            break;
                        }
                    }
                }while(!unique);         
            }
            return randomWords;
        }

        /// <summary>
        /// (1,5 punti) Dato un array passato come parametro, restituire gli elementi aventi 
        /// indice corrispondente a tutti i numeri corrispondenti a un numero nella successione di
        /// fibonacci.
        /// </summary>
        /// <param name="values">L'array di elementi da campionare</param>
        /// <example>
        /// int[] values = { 1, 0, 10, 9, 5 };
        /// int[] result = Esercizio5(values);
        /// Console.WriteLine(String.Join(',', result)); // 1,0,0,9
        /// int[] values2 = { 3, 10, 11, 9, 5, 13, 25, 87, 99, 1 };
        /// result = Esercizio5(values2);
        /// Console.WriteLine(String.Join(',', result)); // 3,10,10,9,13,99
        /// </example>
        public static int[] Esercizio5(int[] values)
        {
            int first = 0;
            int second = 1;

            int N = values.Length;

            

            int[] fibonanccis = new int[N];

            if (N > 0)
            {
                fibonanccis[0] = values[first];
            }

            int i = 1;
            while (second < N)
            {
                int third = first + second;
                fibonanccis[i] = values[second];

                first = second;
                second = third;

                

                i++;
            }
            Array.Resize(ref fibonanccis, i);

            return fibonanccis;
        }
    }
}
