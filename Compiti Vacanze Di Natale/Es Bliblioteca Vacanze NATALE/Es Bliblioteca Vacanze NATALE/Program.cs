using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Es_Bliblioteca_Vacanze_NATALE
{
    internal class Program
    {
        private static void StampaVettore(int[] vet)
        {
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        private static int LeggiNumero(string message)
        {
            int n;
            bool isCorrect = false;

            do
            {
                Console.Write(message);
                int.TryParse(Console.ReadLine(), out n);

                if (n < 0)
                {
                    Console.WriteLine("Il codice ISBN deve essere positivo!");
                    isCorrect = false;
                }
                else isCorrect = true;

            } while (!isCorrect);

            return n;
        }

        private static int RicercaSequenziale(int[] vet, int valore, out double confronti)
        {
            confronti = 0;

            for(int i = 0; i < vet.Length; i++)
            {
                if(vet[i] == valore)
                {
                    return i;
                }
                confronti++;
            }
            return -1;
        }

        private static int RicercaDicotomica(int[] vet, int value, out double confronti)
        {
            confronti = 0;
            int i = 0;
            int lenght = vet.Length - 1;

            while (i <= lenght)
            {
                int medium = i + (lenght - i) / 2;

                if (vet[medium] == value)
                {
                    return medium;
                }

                if(vet[medium] < value)
                {
                    i = medium + 1;
                }
                else
                {
                    lenght = medium - 1;
                }

                confronti++;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] isbn = {1523, 4521, 7894, 2341, 8765, 3456, 9012, 6543, 1234, 5678,
                            3210, 7650, 4320, 8901, 2109, 6789, 3987, 7123, 5432, 9876};

            int[] isbnOrdinato = {1234, 1523, 2109, 2341, 3210, 3456, 3987, 4320, 4521, 5432,
                                        5678, 6543, 6789, 7123, 7650, 7894, 8765, 8901, 9012, 9876 };

            Console.WriteLine("===== GESTIONE BIBLIOTECA DIGITALE =====\n");
            Console.Write("Libri Disponibili (ISBN): ");

            StampaVettore(isbn);
            Console.WriteLine("\n");

            Console.Write("Libri Disponibili (ISBN Ordinato): ");
            StampaVettore(isbnOrdinato);
            Console.WriteLine();

            int value = 1;


            while (value != 0)
            {
                if (value != 0)
                {
                    value = LeggiNumero("\nInserisci L'ISBN del libro da cercare (0 per uscire): ");

                    double confronti_seq = 0;
                    double confronti_dic = 0;

                    int i = RicercaSequenziale(isbn, value, out confronti_seq);
                    int j = RicercaDicotomica(isbnOrdinato, value, out confronti_dic);


                    if (i != -1 && j != -1)
                    {
                        Console.WriteLine("\n--- RISULTATI RICERCA ---");

                        Console.WriteLine("\n1) RICERCA SEQUENZIALE: ");
                        Console.WriteLine("   ✓ Libro trovato alla posizione " + i);
                        Console.WriteLine("   Confronti effettuati: " + confronti_seq);

                        Console.WriteLine("\n2) RICERCA DICOTOMICA: ");
                        Console.WriteLine("   ✓ Libro trovato alla posizione " + j);
                        Console.WriteLine("   Confronti effettuati: " + confronti_dic);

                        double DifConfronti;
                        double PercentualeConfronti;

                        Console.WriteLine("\n--- ANALISI EFFICENZA ---");

                        if (confronti_seq > confronti_dic)
                        {
                            DifConfronti = confronti_seq - confronti_dic;
                            PercentualeConfronti = (DifConfronti / confronti_seq) * 100;

                            Console.WriteLine("La ricerca dicotomica è più efficente!");
                            Console.WriteLine($"Risparmio: {DifConfronti} ({PercentualeConfronti:F2}%)");
                        }
                        else if (confronti_seq < confronti_dic)
                        {
                            DifConfronti = confronti_dic - confronti_seq;
                            PercentualeConfronti = (DifConfronti / confronti_dic) * 100;

                            Console.WriteLine("La ricerca sequenziale è più efficente!");
                            Console.WriteLine($"Risparmio: {DifConfronti} ({PercentualeConfronti:F2}%)");
                        }
                    }

                    if (j == -1 && i == -1 && value != 0)
                    {
                        Console.WriteLine("Libro non trovato!");
                    }

                    if (value == 0) Console.WriteLine("\n---PROGRAMMA TERMINATO---");
                } 
            } 
        }
    }
}
