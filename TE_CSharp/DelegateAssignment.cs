using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public delegate void BankDelegate(string bankName, string intrestRate);

    internal class DelegateAssignment
    {
        public void BankSbi(string bankName, string intrestRate)
        {
            Console.WriteLine($"The interest rate for {bankName} is {intrestRate}");
        }
        public void BankHdfc(string bankName, string intrestRate)
        {
            //Console.WriteLine($"The interest rate for {bankName} is {intrestRate}");
        }
        public void BankKotak(string bankName, string intrestRate)
        {
            //Console.WriteLine($"The interest rate for {bankName} is {intrestRate}");
        }
        public void BankAxis(string bankName, string intrestRate)
        {
            //Console.WriteLine($"The interest rate for {bankName} is {intrestRate}");
        }
        public void BankIcici(string bankName, string intrestRate)
        {
            //Console.WriteLine($"The interest rate for {bankName} is {intrestRate}");
        }
        public static void Main()
        {
            DelegateAssignment delegateAssignment = new DelegateAssignment();
            BankDelegate Bankdelegate = delegateAssignment.BankSbi;
            Bankdelegate("SBI", "2.70%");
            Bankdelegate("HDFC", "3.00% - 3.50%");
            Bankdelegate -= delegateAssignment.BankHdfc;
            Bankdelegate("Kotak Mhindra Bank", "3.50%");
            Bankdelegate -= delegateAssignment.BankKotak;
            Bankdelegate("Axis Bank", "3.00% - 3.50%");
            Bankdelegate -= delegateAssignment.BankAxis;
            Bankdelegate("ICICI", "3.00% - 3.50%");
            Bankdelegate -= delegateAssignment.BankIcici;
        }
    }
}
