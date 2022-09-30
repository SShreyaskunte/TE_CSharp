using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TE_CSharp
{
    public class EmpDetails
    {
        public string EmpName1 = "John";
        public int EmpID1 = 100;
        internal string EmpName2 = "Peter";
        internal int EmpID2 = 101;

        public void MessagePrint(string name)
        {
            Console.WriteLine("Hello " + name+", from public method");
        }

        internal void PrintMessage(string name)
        {
            Console.WriteLine("Hello " + name + ", from internal method");
        }
    }
    internal class AcessSpecifiersAssingment
    {
        public static void Main()
        {
            EmpDetails empDetails = new EmpDetails();
            Console.WriteLine($"This is {empDetails.EmpName1} and my ID is {empDetails.EmpID1} and I am public.");
            Console.WriteLine($"This is {empDetails.EmpName2} and my ID is {empDetails.EmpID2} and I am internal.");
            empDetails.MessagePrint("Macclum");
            empDetails.PrintMessage("Bond");
        }

    }
}
