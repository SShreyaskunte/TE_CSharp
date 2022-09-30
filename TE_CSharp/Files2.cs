using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class FilesDemo2
    {
        public void FileDemo()
        {
            File.WriteAllText(@"C:\Users\EI13044\Desktop\Docs\TE1.txt", "I am WriteAllText method from File class");
            string path = @"C:\Users\EI13044\Desktop\Docs\TE1.txt";
            FileInfo fi = new FileInfo(path);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.Exists );
        }
        public void DirectoryDemo()
        {
            foreach (string file in Directory.GetFiles(@"C:\Users\EI13044\Desktop\Docs\"))
            {
                Console.WriteLine(file);
            }
        }
    }
    
    internal class Files2
    {
        public static void Main()
        {
            FilesDemo2 filesDemo2 = new FilesDemo2();   
            filesDemo2.FileDemo();
            filesDemo2.DirectoryDemo();
        }
    }
}
