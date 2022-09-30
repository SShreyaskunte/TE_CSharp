using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public delegate void Empdelegate(int empid, string empname);
    public delegate void Empdelegate1(int empid, string empname);


    public class Employees
    {
        public void GetITLeadDetails(int empid, string empname)
        {
            Console.WriteLine($" IT : {empid} : {empname}");
        }
        public void GetTestingLeadDetails(int empid, string empname)
        {
            Console.WriteLine($"Tetsing : {empid} : {empname}");
        }
    }
    internal class Delegates
    {
        public static void Main()
        {
            Employees employee = new Employees();
            Empdelegate Empdelegate = employee.GetITLeadDetails;
            Empdelegate(100, "John Cena");
            Empdelegate = employee.GetTestingLeadDetails;
            Empdelegate(101, "Peter Parker");
            Empdelegate1 empdelegate1 = employee.GetITLeadDetails;
            empdelegate1 += employee.GetTestingLeadDetails;
            Console.WriteLine("Team lead for IT and Testing");
            empdelegate1(101, "Sam witchwiki");
            Console.WriteLine("Project lead for IT");
            empdelegate1 -= employee.GetTestingLeadDetails;
            empdelegate1(201, "Mark Roffulo");
         }
    }
}
