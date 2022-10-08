using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class ExceptionDemo1
    {
        float result = 0;
        public void Divide(float a, float b)
        {
            try
            {
                result = a / b;
                if (float.IsInfinity(result))
                {
                    Console.WriteLine("Division by zero");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by Zero");
            }

            finally
            {
                Console.WriteLine(result);
            }
        }
        public void ArrayIndex()
        {
            try
            {
                int[] num = { 1, 2, 3 };
                Console.WriteLine(num[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.TargetSite);
            }

        }
        public void MultipleCatch()
        {
            int[] a = { 10, 8, 6, 4, 8, 2 };
            int[] b = { 5, 0, 3, 0, 2 };
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    Console.WriteLine(a[i] / b[i]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

    }
    internal class ExceptionsAssignment
    {
        public static void Main()
        {
            ExceptionDemo ex = new ExceptionDemo();
            ex.Divide(10.10f, 0);
            Console.WriteLine("-------------------------------------------");
            ex.ArrayIndex();
            Console.WriteLine("-------------------------------------------");
            ex.MultipleCatch();
        }
    }
}
