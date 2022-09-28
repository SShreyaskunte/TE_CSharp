using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Constructors - special methods,same name of the class name,no return type,automatically invoked,overloaded
    /// Destructor - Garbage Collection - Dispose() - Explicit and Finalize() - Implicit 
    /// Destructor - same name of the class name,no return type,no access specifier,only one destructor,prefix ~ tilde
    /// </summary>

    public class Employee
    {
        public int id;
        public string name;

        public Employee()
        {
            id = 1;
            name = "John";
            Console.WriteLine($"{name}: {id}");
        }
        /// <summary>
        /// Constructor overloaded with one parameter
        /// </summary>
        /// <param name="age"></param>
        public Employee(int age)
        {
            id = 10;
            name = "Peter Parker";
            Console.WriteLine($"{id}:{name}:{age}");
        }

        public void Display()
        {
            Console.WriteLine($"{name} {id}");

        }

        /// <summary>
        /// Destructor - Automatically invoked at the end of the program and free up the memory
        /// Finalize() - Implicit
        /// </summary>
        
        ~Employee()
        {
            Console.WriteLine("I am a Destructor");//to see this line in output run in online compiler
        }
    }

    internal class Constructors
    {
        public static void Main()
        {
            Employee emp = new Employee();
            Employee emp2 = new Employee();
            emp.Display();
        }
    }
}
