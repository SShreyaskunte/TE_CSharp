using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public abstract class Bonus
    {
        protected int bonus;

        public abstract void GetBonus();
        public void CalBonus(int salary)
        {
            bonus = bonus* salary;
            Console.WriteLine($"Bonus is : {bonus}");
        }

    }
     
    public class IT : Bonus
    {
        public override void GetBonus()
        {
            bonus = 5;
        }

    }
    public class TestingDept : Bonus
    {
        public override void GetBonus()
        {
            bonus = 3;
        }

    }

    internal class Abstraction
    {
        
    public static void Main()
    {
            Bonus bonus;
            bonus = new IT();
            bonus.GetBonus();
            bonus.CalBonus(20000);
            bonus = new TestingDept();
            bonus.GetBonus();
            bonus.CalBonus(20000);
        }
         
    }
}
