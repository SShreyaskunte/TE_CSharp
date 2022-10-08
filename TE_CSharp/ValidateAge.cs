using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
            : base(message)
        {

        }
    }
    public class ValidateAgeEngine
    {
        public void IsValid(int age)
        {
            if(age < 22)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 22.");
            }
            else
            {
                Console.WriteLine("Age is greater than 22.");
            }
        }
    }
    internal class ValidateAge
    {
        public static void Main(string[] args)

        {
            ValidateAgeEngine validateAge = new ValidateAgeEngine();
            try
            {
                validateAge.IsValid(32);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e); }
        }
    }
}
