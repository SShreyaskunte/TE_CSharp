using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Program
    {
        private int empid;
        private string empname;

        public int EmployeeID
        {
            get { return empid; }
            set { empid = value; }
        }
        public string EmployeeName
            { get { return empname; } set { empname = value; } }

        public void Display()
        {
            Console.WriteLine($"{empname}:{empid}");
        }
    }
    internal class Encapsulation
    {
        private static void Main()
        {
            Program p =  new Program();
            p.EmployeeID = 100;
            p.EmployeeName = "John";
            Console.WriteLine(p.EmployeeID);
            Console.WriteLine(p.EmployeeName);
        }
    }
}
