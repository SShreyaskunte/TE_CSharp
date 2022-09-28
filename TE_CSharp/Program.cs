using System; //Namespaces - collection of classes, in clasess we have collection of methods

//user defined namespace
namespace Basic_Concepts
{

    /// <summary>
    /// Basic C-Sharp concepts
    /// </summary>
    class Program
    {
        public static void Main(String[] args)
        {
            //console -> class, writeline -> metod
            Console.WriteLine("Welcome to C-Sharp");

            //datatypes
            int a = 20;
            double b = 12.20;
            char c = 'a';
            string e = "John";

            //display 
            Console.WriteLine(a);
            Console.WriteLine("Double Value is: "+b);
            Console.WriteLine("Char value is: {0}", c);
            //string interpolation
            Console.WriteLine($"Hi {e}, how are you? There are {a} days remaining bro");
            //multiple index
            Console.WriteLine("I am {0} and my age is {1}", e, a);

            //accept input
            int empid;
            string empname;
            Console.WriteLine("EM Details : ");
            Console.WriteLine("EM ID : ");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("EM Name : ");
            empname = Console.ReadLine();
            Console.WriteLine($"{empname}'s id is {empid}");
            Console.WriteLine("-------------------------------------");

            //Functions
            //MATH

            Console.WriteLine("Math Function");
            Console.WriteLine(Math.Round(12.59));
            Console.WriteLine(Math.Floor(12.78));
            Console.WriteLine(Math.Ceiling(12.78));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Abs(-12.78));
            Console.WriteLine("---------------------------------------");

            //String functions

            Console.WriteLine("String Functions");
            string course = "Dotnet full stack ";
            string anothercourse = "JAVA";
            Console.WriteLine(course.IndexOf("t"));
            Console.WriteLine(course.ToUpper());
            Console.WriteLine(course.Substring(0, 6));
            Console.WriteLine(string.Concat(course, anothercourse));
            
            //Escape seq

            Console.WriteLine("\"Hello\",\'how are you\'");
            Console.WriteLine("---------------------------------------");


            double num = 12.36;
            Console.WriteLine(num);
            int num1 = (int)num;
            Console.WriteLine();
        }

    }
}