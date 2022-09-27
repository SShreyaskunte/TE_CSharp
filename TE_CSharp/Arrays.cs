using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Arrays
    {
        /// <summary>
        /// Arrays - collection of elements of same datatypes
        /// </summary>
        public static void Main()
        {
            Array_1D();
            Array_2D();
        }

        /// <summary>
        /// !D arrays and array functions
        /// </summary>
        public static void Array_1D()
        {
            int[]  array = new int[] { 1,2,3,4,8,6,9,5};
            Console.WriteLine("1-D Array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Functions");
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Count());
            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Average());
            Console.WriteLine("---------------------------------------");
            Array.Sort(array);
            Console.WriteLine("Sorted array");
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("---------------------------------------");
            Array.Reverse(array);
            Console.WriteLine("Reveresed array");
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("---------------------------------------");

        }

        /// <summary>
        /// 2D array
        /// </summary>
        public static void Array_2D()
        {
            int[,] array = new int[,]
            {
                {1,2,3,4},
                {5,6,7,8}
            };

            Console.WriteLine("2-D Array");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]);
                }
                Console.WriteLine("\n");
            }
        }

        /// <summary>
        /// Array of arrays
        /// </summary>
        public static void Jagged_Array()
        {

        }
    }
}
