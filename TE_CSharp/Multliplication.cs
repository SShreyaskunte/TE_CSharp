using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Multliplication
    {

        public static void Main()
        {
            int[] numSeries = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Multiply(numSeries);
        }

        public static void Multiply(params int[] numSeries)
        {
            int multipleOf = 2;
            foreach(int i in numSeries)
            {
                Console.WriteLine($"{2}  *  {i}    =    " + (2 * i));
            }
        }

    }
}
