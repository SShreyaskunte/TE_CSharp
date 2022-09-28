using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Matrix
    {
        public static void Main()
        {
            int[,] array1 = new int[,]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 }
            };

            Console.WriteLine("The Matrix 1  : ");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write(array1[i, j]);
                }
                Console.WriteLine("\n");
            }

            int[,] array2 = new int[,]
            {
                { 5, 6, 7, 8 },
                { 1, 2, 3, 4 }
            };
            Console.WriteLine("The Matrix 2 : ");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i, j]);
                }
                Console.WriteLine("\n");
            }

            int[,] array3 = new int[2,4];

            for(int i = 0; i < array3.GetLength(0); i++)
            {
                for(int j = 0; j < array3.GetLength(1); j++)
                {
                    array3[i, j] = array1[i, j] + array2[i, j];
                }
            }

            Console.WriteLine("The sum of two matrix are : ");
            for(int i = 0; i < array3.GetLength(0); i++)
            {
                for(int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write(" "+array3[i,j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
