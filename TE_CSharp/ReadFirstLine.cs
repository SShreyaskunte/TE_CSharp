using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class ReadFirstLine
    {
        public static void Main()
        {
            string path = @"C:\Users\EI13044\Desktop\Docs\Assignments\C#\Multiplication.txt";

            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content[0]);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
