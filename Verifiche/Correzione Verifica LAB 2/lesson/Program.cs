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
                        int min = 0;
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
            char choice;
            //bool ok;

            do
            {
                Console.WriteLine("A -> Esercizio 1");
                Console.WriteLine("B -> Esercizio 2");
                Console.WriteLine("C -> Esercizio 3");
                Console.WriteLine("D -> Esercizio 4");
                Console.WriteLine("E -> Esercizio 5");
                Console.WriteLine("X -> Esci dal programma");

                // soluzione 1: Convert.ToString()[0] oppure Convert.ToChar()
                choice = Convert.ToChar(Console.ReadLine()!);
            } while (choice < 'A' || choice > 'E' && choice != 'X');
            // soluzione 2: char.TryParse
            //ok = char.TryParse(Console.ReadLine(), out choice);
            //} while (ok && choice < 'A' || choice > 'E' && choice != 'X');

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
            string[] result = new string[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = convertToBinary(numbers[i]);
            }

            return result;
        }

        private static string convertToBinary(int number)
        {
            string binary = "";

            while (number > 0)
            {
                int digit = number % 2;

                // compito a casa (difficilotto): c'è troppa
                // allocazione di stringhe in memoria. Se il numero
                // è grande serve tanta RAM. Risolvere.
                binary = Convert.ToString(digit) + binary;

                number = number / 2;
            }

            return binary;
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
            int result = -1; // caso peggiore? non si trova niente

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Length == size)
                {
                    // sto cercando l'ultima, no return!
                    result = i;
                }
            }

            return result;
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
            int inf = 0;
            int sup = numbers.Length - 1;

            while (inf <= sup)
            {
                int mid = (inf + sup) / 2;

                if (value == numbers[mid])
                {
                    return mid;
                }
                else if (value > numbers[mid])
                {
                    // cerco a destra ">"
                    // la porzione da cercare è mid + 1 ... sup
                    inf = mid + 1;
                }
                else // if (value < numbers[mid])
                {
                    // cerco a sinistra "<"
                    // la porzione da cercare è inf ... mid - 1
                    sup = mid - 1;
                }
            }

            // se arrivo qui non ho trovato il numero
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
            // condizione di guardia (opzionale)
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            // cerco di capire quanti numeri generare
            int intervalSize = max - min;
            // se devo generarne meno del massimo possibile,
            // li genero. Altrimenti sto sul massimo.
            if (n < intervalSize)
            {
                intervalSize = n;
            }

            int[] numbers = new int[intervalSize];
            for (int i = 0; i < numbers.Length; i++)
            {
                bool distinct;

                do
                {
                    // generiamo un numero casuale
                    numbers[i] = rnd.Next(min, max);

                    // controlliamo se è distinto (ricerca seq.)
                    distinct = subArrayContains(numbers, 0, i - 1, numbers[i]);
                } while (distinct);
            }

            return numbers;
        }

        /// <summary>
        /// Returns wether the specified number is contained in the numbers array
        /// portion delimited by start and end indexes.
        /// </summary>
        /// <param name="numbers">The numbers array</param>
        /// <param name="start">The start index (included)</param>
        /// <param name="end">The end index (included)</param>
        /// <param name="number">The number to search</param>
        /// <returns>True if the number is contained, false otherwise</returns>
        private static bool subArrayContains(int[] numbers, int start, int end, int number)
        {
            bool found = false;
            int j = start;

            while (!found && j <= end)
            {
                //opzione corta: distinct = number == numbers[j++];
                if (number == numbers[j])
                {
                    found = true;
                }

                j++;
            }

            return found;
        }
    }
}


