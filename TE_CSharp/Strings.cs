using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Strings
    {
        public static void Main()
        {
            stringDemo();
            stringBuilderDemo();
        }

        public static void stringDemo()
        {
            string fname = "John";
            string lname = "Kelly";
            Console.WriteLine(fname);
            Console.WriteLine(lname);
            //group of chracters using char array

            char[] name = { 's', 'a', 'm' };

            //string -> class

            String s = new string(name);
            string s1 = new string(s);
            Console.WriteLine(s);
            Console.WriteLine(s1);

            foreach (char c in name)
            {
                Console.Write(c);
            }
            Console.WriteLine("-------------------------");

            Console.WriteLine("\\\\TE\\CSharp");
            //Verbatim Strings
            Console.WriteLine(@"\\TE\CSharp");
            Console.WriteLine("-------------------------");
        }

        public static void stringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder("Dotnet");
            Console.WriteLine(sb.ToString());
            sb.Append(" Full Stack");
            Console.WriteLine(sb.ToString());
            sb.Append(" Development");
            Console.WriteLine(sb.ToString());
        }

    }
}
