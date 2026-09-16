using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_29_01_2026_LAB
{
    internal class Program
    {
        static Random rnd = new Random();

        /// <summary>
        /// Carica un array di n numeri casuali, fra min e max(entrambi compresi)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int[] RandomLoadArray(int n, int min, int max)
        {
            if(n <= 0 || max < min)
            {
                return null;
            }

            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }

            return array;
        }

        public void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public string ArrayToString(int[] array)
        {
            string vet = "";

            for(int i = 0; i < array.Length; i++)
            {
                vet += array[i] + " ";
            }

            return vet;
        }

        public int GreaterElementOfArray(int[] array)
        {
            int max = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public int GraterElementOfSubArray(int[] array, int start, int end)
        {
            CheckSubArrayIndices(array, ref start, ref end);

            int max = 0;

            for (int i = start; i < end; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public bool ArrayContainsElement(int[] array, int element)
        {
            return SubArrayContainsElement(array, 0, array.Length, element);
        }

        private bool SubArrayContainsElement(int[] array, int start, int end, int element)
        {
            CheckSubArrayIndices(array, ref start, ref end);

            bool found = false;

            int i = start;

            while(i <= end && !found)
            {
                if (array[i] == element)
                {
                    found = true;
                }
            }

            return found;
        }

        public int[] SortedArray(int[] array)
        {
            int[] res = new int[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                res[i] = array[minIndex];
            }

            return res;
        }

        public void SortSubArray(int[] array, int start, int end)
        {
            CheckSubArrayIndices(array, ref start, ref end);

            for (int i = start; i <= end; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j <= end; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }


                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }

        public void SortArray(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if(minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }

        public void CheckSubArrayIndices(int[] array, ref int start, ref int end)
        {
            if (start < 0)
            {
                start = 0;
            }

            if (end > array.Length - 1)
            {
                end = array.Length - 1;
            }

            if (start > end)
            {
                int temp;
                temp = start;
                start = end;
                end = temp;
            }
        }
    }
}
