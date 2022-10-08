using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Add
    {
        public Add(int a, int b)
        {
            Console.WriteLine("Construcor that takes int arguments : "+(a + b));
        }

        public Add(float a, float b)
        {
            Console.WriteLine("Construcor that takes float arguments : " + (a + b));
        }
        public Add(string a, string b)
        {
            Console.WriteLine("Construcor that takes string arguments : " + (a + b));
        }
    }
    internal class ConstructorOverloading
    {
        public static void Main()
        {
           
            Add add = new Add(2,3);
            Add add1 = new Add(2.5F, 3.5F);
            Add add2 = new Add("Peter", " Parker");

        }
    }
}
