using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public delegate void PassCallback(int a, int b);
    
    public class Calculator
    {
        public void Add(int a,int b)
        {
            Console.WriteLine($"{a + b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"{a - b}");
        }
        public void Divide(int a, int b)
        {
            Console.WriteLine($"{a / b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"{a * b}");
        }
    }
    internal class PassDelegate
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            Values(calculator.Sub, 10, 20);
        }

        public static void Values(PassCallback delgte, int a, int b)
        {
            delgte(a,b);
        }
    }
}
