using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class NumberOfLines
    {
        public static void Main()
        {
            string path = @"C:\Users\EI13044\Desktop\Docs\Assignments\C#\Multiplication.txt";

            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content.Length);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
