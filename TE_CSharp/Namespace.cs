using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace1
{
    internal class Class1
    {
        public static void Method1()
        {
            Console.WriteLine("Message 1");
        }
    }
}

namespace Namespace2
{
    internal class Class1
    {
        public static void Method1()
        {
            Console.WriteLine("Message 2");
        }
    }
}

namespace Namespace3
{
    namespace NestedNamespace1
    {
        internal class Class1
        {
            public static void Method1()
            {
                Console.WriteLine("Message in Nested Namespace 1");
            }
        }
    }
    namespace NestedNamespace2
    {
        internal class Class1
        {
            public static void Method1()
            {
                Console.WriteLine("Message in Nested Namespace 2");
            }
        }
    }
}


namespace MainNamespace
{
    internal class Class1
    {
        public static void Main()
        {
            Namespace1.Class1.Method1();
            Namespace2.Class1.Method1();
            Namespace3.NestedNamespace1.Class1.Method1();
            Namespace3.NestedNamespace2.Class1.Method1();
        }
    }
}
