using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class StudentDetails
    {
        public static void Main()
        {
            int id;
            string name;
            string dept;
            StDetails(out id, out name, out dept);
            Console.WriteLine();
        }

        public static void StDetails(out int SId, out string SName, out string SDept)
        {
            SId = 1;
            SName = "Shreyas";
            SDept = "CSE";
        }
    }
}
