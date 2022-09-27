using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{

    /// <summary>
    /// Control Statements and types of methods
    /// </summary>
    internal class control
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome Control");
            //Conditional(); because it is static
            control control = new control();
            control.Conditional(); //because it is static
            control.Looping(); // because it is instance method
        }

        //Static method, called only once
        public static void Conditional()
        {
            Console.WriteLine("conditional statement");
            //relatioonal and logical operators
            int a, b, c;
            Console.WriteLine("Enter the values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The values of a,b and c are : {0}, {1} and {2}",a, b, c);
            if((a>b) && (a>c))
            {
                Console.WriteLine("a is the greatest");
            }
            else if(b>c)
            {
                Console.WriteLine("b is the greatest");
            }
            else
            {
                Console.WriteLine("c is the greatest");
            }

            Console.WriteLine("----------------------------------------------------------------------");

        }

        //instance method
        public void Looping()
        {
            Console.WriteLine("Looping statement");
            //arrays 
            int[] numbers1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] numbers2 = new int[7] { 1, 2, 3, 4, 5, 6,7 };
            int[] numbers3 = { 1, 2, 3 };
            int sum = 0;


            //for loop

            for(int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i]);

            }
            Console.WriteLine("----------------------------------------------------------------------");


            //foreach
            foreach (int n in numbers2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------------------------------");
            for(int i = 0; i < numbers3.Length; i++)
            {
                sum = sum + numbers3[i];
            }

            Console.WriteLine("Sum is :"+sum);
            Console.WriteLine("----------------------------------------------------------------------");

            int size;
            Console.WriteLine("Enter the size : ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] courseid = new int[size];
            //for input
            for (int j=0;j<size;j++)
            {
                Console.WriteLine("Enter the value of {0} array", (j + 1));
                courseid[j] = Convert.ToInt32(Console.ReadLine());
            }

            //output
            Console.WriteLine("ELements in array : ");
            foreach(int n in courseid)
            {
                Console.WriteLine(n);
            }
        }
    }
}
