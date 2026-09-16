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
                int[] numbers = { 1, 2, 5, 10};
                int[] result;
                string[] values = { "Aldo", "Bruno", "Carlo"};
                int N = 10;

                switch (choice)
                {
                    case 'A':
                        string[] binaries = Esercizio1(numbers);
                        Console.WriteLine(String.Join(",", binaries));
                        break;
                    case 'B':
                        // modificare per fare delle prove
                        int size = 5;

                        int firstIndex = Esercizio2(values, size);
                        Console.WriteLine(firstIndex);
                        break;
                    case 'C':
                        // modificare per fare delle prove
                        int searchedValue = 10;

                        int searchedIndex = Esercizio3(numbers, searchedValue);
                        Console.WriteLine(searchedIndex);
                        break;
                    case 'D':
                        // esempio per fare delle prove
                        Random rnd = new Random();
                        int min = 1;
                        int max = 10;
                        int[] generatedNumbers = Esercizio4(rnd, min, max, N);
                        Console.WriteLine(String.Join(',', generatedNumbers));
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
        /// X -> Esci dal programma
        /// </summary>
        /// <returns>
        /// La voce scelta, se corretta.
        /// Se la scelta non è valida, riproporre nuovamente
        /// il menù finché non si sceglie correttamente.
        /// </returns>
        public static char Menu()
        {
            bool isCorrect = false;
            char choice;

            do
            {
                Console.WriteLine("A -> Esercizio 1");
                Console.WriteLine("B -> Esercizio 2");
                Console.WriteLine("C -> Esercizio 3");
                Console.WriteLine("D -> Esercizio 4");
                Console.WriteLine("X -> Esci dal programma");

                char.TryParse(Console.ReadLine(), out choice);

                if (choice >= 'A' && choice <= 'D' || choice == 'X')
                {
                    isCorrect = true;
                }

            } while (!isCorrect);

            return choice;
        }

        /// <summary>
        /// (2 punti) Restituisce la rappresentazione binaria dei numeri passati come parametro.
        /// </summary>
        /// <param name="numbers">L'array di numeri da considerare per la conversione</param>
        /// <returns>
        /// Un vettore di stringhe contenente le conversioni in binario corrispondenti.
        /// </returns>
        /// <example>
        /// int[] numbers = { 1, 2, 5, 10 };
        /// Console.WriteLine(String.Join(",", Esercizio1(numbers))); // 1,10,101,1010
        /// </example>
        public static string[] Esercizio1(int[] numbers)
        {
            int j = 0;
            string [] res = new string[numbers.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                while (numbers[i] != 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        res[i] = "0" + res[i];
                    }
                    else
                    {
                        res[i] = "1" + res[i];
                    }
                    numbers[i] /= 2;
                }

                j++;
            }
            
            return res;
        }


        /// <summary>
        /// (1,5 punto) Ricerca l'ultima occorrenza in un array ORDINATO fornito come parametro di una stringa con 
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
        /// Console.WriteLine(esercizio2(values, 4)); // 0
        /// Console.WriteLine(esercizio2(values, 5)); // 2
        /// Console.WriteLine(esercizio2(values, 3)); // -1
        /// </example>
        public static int Esercizio2(string[] values, int size)
        {
            int i = 0;
            int j = 0;
            bool trovato = false;

            while(i < values.Length)
            {
                if (values[i].Length == size)
                {
                    j = i;
                    trovato = true;
                }
                i++;
            }
            if (trovato)
            {
                return j;
            }
            else
            {
                return -1;
            }
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
            int i = 0;

            while (i < numbers.Length)
            {
                if (value == numbers[i])
                {
                    return i;
                }
                i++;

            } 
            return -1;
        }

        /// <summary>
        /// (1,5 punti) Crea un array di N numeri casuali DISTINTI fra un minimo e un massimo specificati come parametro.
        /// Se N >= al massimo di numeri distinti generabili, creare al massimo tale numero elementi.
        /// </summary>
        /// <param name="rnd">Il generatore di numeri casuali</param>
        /// <param name="min">Il valore minimo (incluso) del range di numeri casuali</param>
        /// <param name="max">Il valore massimo (escluso) del range di numeri casuali</param>
        /// <param name="n">Il numero di numeri distinti da generare</param>
        /// <returns>
        /// L'array di numeri casuali creato.
        /// </returns>
        /// <example>
        /// Random rnd = new Random();
        /// int min = 0;
        /// int max = 3;
        /// 
        /// // Genero 1 numero distinto tra 0 e 2
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, min, max, 1)); // 1
        /// 
        /// // Genero 2 numeri distinti tra 0 e 2
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, min, max, 2)); // 0,2
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, min, max, 2)); // 1,2
        ///
        /// // Genero 3 numeri distinti tra 0 e 2
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, min, max, 3)); // 0,1,2
        /// 
        /// // Genero 4 numeri distinti tra 0 e 2 (ma ne esistono solo 3, quindi ne genero 3)
        /// Console.WriteLine(String.Join(',', Esercizio4(rnd, min, max, 4)); // 0,2,1
        /// </example>
        public static int[] Esercizio4(Random rnd, int min, int max, int n)
        {
            int newNumber;
            bool isDuplicated;

            int i = 0;

            int[] vet = new int[n];

            do
            {
                newNumber = rnd.Next(min, max);
                isDuplicated = false;

                for (int j = 0; j < n - 1; j++)
                {
                    if (newNumber == vet[j])
                    {
                        isDuplicated = true;
                        break;
                    }
                }

                if (!isDuplicated)
                {
                    vet[i] = newNumber;
                    i++;
                }

            } while (i < n && isDuplicated);

            return vet;
        }
    }
}



