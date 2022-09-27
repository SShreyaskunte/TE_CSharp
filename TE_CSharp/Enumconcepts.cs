using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Enumconcepts
    {
        enum CSharp_concepts
        {
            Basics,
            Methods = 10,
            ControlStmts,
            OOPS = 20,
            Delegates = 40,
            Structures = -3,
            Files,
            Generics
        }
        public static void Main()
        {
            Console.WriteLine(CSharp_concepts.Basics);
            int methods = (int)CSharp_concepts.Methods;
            Console.WriteLine(methods);
            var del = (CSharp_concepts)40;
            Console.WriteLine(del);
            int structures = (int)CSharp_concepts.Structures;
            Console.WriteLine(structures);
        }
    }
}
