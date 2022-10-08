using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Bonus1
    {
        public void BonusCalculator(int salary, int bonus)
        {
            Console.WriteLine("The bonus is : " + (salary * bonus));
        }
    }

    public class Staff : Bonus1 
    {
        public void StaffBonus()
        {
            BonusCalculator(6000,3);
        }
    }

    public class NonStaff : Bonus1
    {
        public void NonStaffBonus()
        {
            BonusCalculator(3000,2);
        }
    }
    internal class InheritedAndAccessSpecifier
    {
        public static void Main()
        {
            Staff staff = new Staff();
            NonStaff nonstaff = new NonStaff();
            staff.StaffBonus();
            nonstaff.NonStaffBonus();
        }
    }
}
