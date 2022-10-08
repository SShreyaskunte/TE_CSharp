using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class FilesMultiplication
    {
        public static void Write()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13044\Desktop\Docs\Assignments\C#\Multiplication.txt");
            FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fs);

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        writer.WriteLine($"{i} * {j} = {i * j}");
                    }
                    Console.Write("\n");
                    Console.Write("\n");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fs.Close();
            }
        }

        public static void Read()
        {
            FileInfo fileinfo = new FileInfo(@"C:\Users\EI13044\Desktop\Docs\Assignments\C#\Multiplication.txt");
            FileStream fs = fileinfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fs);

            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fs.Close();
            }

        }

        public static void Main()
        {
            Write();
            Read();
        }
    }
}
