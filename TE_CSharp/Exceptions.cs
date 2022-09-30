﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ERRORS - Syntax error,Compile time, Logical error,Runtime error
/// Exception Handling - Runtime errors - try,catch,finally,throw
/// Exceptions - Pre-defined and user-defined 
/// EXCEPTION - BASE CLASS 
/// Predefined classes - Exception(Base) -> SystemException -> ArithmeticException -> DivideByZeroException
/// </summary>
namespace TE_CSharp
{

    public class ExceptionDemo
    {
        float result = 0;
        /// <summary>
        /// DivideByZeroException 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public void Divide(float num1, float num2)
        {
            try
            {
                result = num1/num2;
                if (float.IsInfinity(result))
                {
                    Console.WriteLine("DIvision by zero is not allowed");
                }
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by Zero");
            }

            finally
            {
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// IndexOutOfRangeException
        /// </summary>
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
        /// <summary>
        /// Multiple catch blocks
        /// </summary>
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
    internal class Exceptions
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
