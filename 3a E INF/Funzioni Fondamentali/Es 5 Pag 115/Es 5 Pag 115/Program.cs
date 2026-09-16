using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Es_5_Pag_115
{
    internal class Program
    {
        private static string[] CopiaVettore(string squadra, string[] squadre, string[] nomi, string[] cognomi)
        {
            int[] vetSquadre = new int[squadre.Length];
            int count = 0;

            for (int i = 0; i < squadre.Length; i++)
            {
                if (squadra == squadre[i])
                {
                    vetSquadre[count] = i;
                    count++;
                }
            }


            string[] vetNomi = new string[count];
            int nNomi = 0;


            for (int i = 0; i < count; i++)
            {

                int j = vetSquadre[i];

                vetNomi[nNomi] = nomi[j] + " " + cognomi[j];
                nNomi++;
            }

            return vetNomi;
        }

        private static string[] BubbleSort(string[] vet)
        {
            for (int i = 0; i < vet.Length - 1; i++)
            {
                for (int j = 0; j < vet.Length - 1 - i; j++)
                {
                    if (String.Compare(vet[j], vet[j + 1]) > 0)
                    {
                        string temp = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = temp;
                    }
                }
            }

            return vet;
        }

        private static void StampaVettore(string[] vet)
        {
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            string[] cognomi = {
                                "Rossi",
                                "Bianchi",
                                "Verdi",
                                "Esposito",
                                "Ferrari",
                                "Romano",
                                "Gallo",
                                "Conti",
                                "DeLuca",
                                "Mancini"
                                };

            string[] nomi = {
                            "Marco",
                            "Luca",
                            "Andrea",
                            "Giuseppe",
                            "Paolo",
                            "Antonio",
                            "Francesco",
                            "Stefano",
                            "Matteo",
                            "Davide"
                            };

            string[] squadre = {
                            "Juventus",
                            "Juventus",
                            "Inter",
                            "Napoli",
                            "Roma",
                            "Roma",
                            "Atalanta",
                            "Inter",
                            "Torino",
                            "Juventus"
                            };

            Console.WriteLine("Inserire il nome di una squadra: ");
            string squadra = Console.ReadLine();

            string[] vet = CopiaVettore(squadra, squadre, nomi, cognomi);

            vet = BubbleSort(vet);

            Console.WriteLine($"\nGiocatori della squadra {squadra}:");
            StampaVettore(vet);

            Console.ReadLine();
        } 
    }
}
