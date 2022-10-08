using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Generic class
    /// </summary>
    internal class Generics<T>
    {
        //Generic Varibale
        public T genericVariable;

        public Generics(T val)
        {
            genericVariable = val;
        }

        public void GenericMethod(T genericParameter)
        {
            Console.WriteLine($"{genericParameter}");
        }

        public T genericProperty
        {
            get;
            set;
        }
    }
}

namespace GenericsEvolution
{
    public class Generics
    {
        public static void Stage1()
        {
            bool result = AreEqual("A", 10);
            if(result)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        public static bool AreEqual(object value1, object value2)
        {
            return value1 == value2;
        }

        public static void Main()
        {
            Stage1();
            Console.WriteLine("-----------------------");
            Stage2();
            Console.WriteLine("-----------------------");
            Stage3();
            Console.WriteLine("-----------------------");
        }

        public static void Stage2()
        {
            bool result = AreEqualInt(10, 10);
            if (result)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        public static bool AreEqualInt(int value1, int value2)
        {
            return value1 == value2;
        }

        public static void Stage3()
        {
            Console.WriteLine("Generic : ");
            bool result = AreEqualGen<int>(1,1);
            bool result1 = AreEqualGen<string>("a", "b");

            if (result1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        public static bool AreEqualGen<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }


    }
}
