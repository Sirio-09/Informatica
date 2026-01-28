using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Es_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int giorno;
            int mese;
            int anno;
            bool cicla = false;

            do
            {
                if (cicla == true)
                {

                    Console.Clear();
                    cicla = false;

                }
                

                Console.Write("Inserire il Giorno: ");
                giorno = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserire il Mese: ");
                mese = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserire l'Anno: ");
                anno = Convert.ToInt32(Console.ReadLine()); 

                if (mese < 1 || mese > 12)
                {

                    cicla = true;

                }
                else
                {

                    switch (mese)
                    {

                        case 2:

                            bool bisesitile = false;

                            if (anno % 4 == 0)
                            {

                                if (anno % 100 == 0)
                                {

                                    if (anno % 400 == 0)
                                    {

                                        bisesitile = true;

                                    }

                                }
                                else
                                {

                                    bisesitile = true;

                                }
                            }

                            if (bisesitile == true && giorno > 29)
                            {

                                cicla = true;

                            }

                            if (giorno > 28)
                            {

                                cicla = true;

                            }
                            break;

                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (giorno > 30)
                            {

                                cicla = true;

                            }
                            break;

                        default:
                            if (giorno > 31)
                            {

                                cicla = true;

                            }
                            break;
                    }


                }



            } while(cicla == true);
             
            Console.Write("La Data è Corretta!\n", giorno + mese + anno);
            Console.ReadKey();



        }
    }
}
