using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class FilesDemo
    {
        public void Write()
        {
            FileInfo fileinfo = new FileInfo(@"C:\Users\EI13044\Desktop\Docs\TE.txt");
            FileStream fs = fileinfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fs);

            try
            {
                writer.WriteLine("Welcome to Files component - Shreyas Kunte");
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

        public void Read()
        {
            FileInfo fileinfo = new FileInfo(@"C:\Users\EI13044\Desktop\Docs\TE.txt");
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
        public void Append()
        {
            FileInfo fileinfo = new FileInfo(@"C:\Users\EI13044\Desktop\Docs\TE.txt");
            FileStream fs = fileinfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fs);

            try
            {
                writer.WriteLine("This part is appended got it???");
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
    }
    internal class Files
    {
        public static void Main()
        {
            FilesDemo demo = new FilesDemo();
            demo.Write();
            demo.Read();
            demo.Append();
        }
    }
}
