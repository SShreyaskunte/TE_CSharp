using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class RegExAssignment
    {
        public static void Main()
        {
            Mobile();
        }
        public static void Mobile()
        {
            Console.WriteLine("Mobile validation");
            string mobile = "9234568900";
            string mobile1 = "8240374232";
            string mobile2 = "7536627880";
            string mobile3 = "4267255242";
            var validate_mobile = Regex.IsMatch(mobile, @"^\(?([7-9]{1})\)?[-. ]?([0-9]{9})$");
            var validate_mobile1 = Regex.IsMatch(mobile1, @"^\(?([7-9]{1})\)?[-. ]?([0-9]{9})$");
            var validate_mobile2 = Regex.IsMatch(mobile2, @"^\(?([7-9]{1})\)?[-. ]?([0-9]{9})$");
            var validate_mobile3 = Regex.IsMatch(mobile3, @"^\(?([7-9]{1})\)?[-. ]?([0-9]{9})$");

            Console.WriteLine("9234568900 is " + validate_mobile);
            Console.WriteLine("8240374232 is "+validate_mobile1);
            Console.WriteLine("7536627880 is "+validate_mobile2);
            Console.WriteLine("4267255242 is " + validate_mobile3);


        }
    }
}
