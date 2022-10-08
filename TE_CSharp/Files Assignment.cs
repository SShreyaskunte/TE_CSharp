using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Files_Assignment
    {
        ///File Moving
        public static void Move()
        {
            string sourceFile = @"C:\Users\EI13044\Desktop\Docs\Assignments\C#\Multiplication.txt";
            string destinationFile = @"C:\Users\EI13044\Desktop\Docs\Assignments\Multiplication.txt";

            System.IO.File.Move(sourceFile, destinationFile);
        }

        public static void Copy()
        {

            string sourceFile = @"C:\Users\EI13044\Desktop\Docs\Assignments\C#\Multiplication.txt";
            string destFile = @"C:\Users\EI13044\Desktop\Docs\Assignments\Multiplication.txt";
            System.IO.File.Copy(sourceFile, destFile, true);

        }

        public static void Delete()
        {
            if (System.IO.File.Exists(@"C:\Users\EI13044\Desktop\Docs\Assignments\C#\Multiplication.txt"))
            {
                try
                {
                    System.IO.File.Delete(@"C:\Users\EI13044\Desktop\Docs\Assignments\C#\Multiplication.txt");
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }

        public static void Main()
        {
            //Move();
            //Copy();
            Delete();
        }
    }
}
