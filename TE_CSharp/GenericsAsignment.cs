using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class GenericsAsignment
    {
        // Declare Generic Delegate
        public delegate T SampleDelegate<T>(T a);
        class Area
        {
            public int Square(int a)
            {
                return a * a;
            }
            public double Square(double a)
            {
                return a * a;
            }
            public int Cube(int c)
            {
                return 6 * (c * c);
            }
            public double Cube1(double c)
            {
                return 6 * (c * c);
            }
            public int Circle(int r)
            {

                return (int)3.142 * (r * r);

            }

            public double Circle(double r)
            {

                return 3.142 * (r * r);

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("*Generic Delegate Example*");
                Area m = new Area();
                Console.WriteLine("-----------Area Using int Values-----------");
                // Instantiate delegate with Square method using int
                SampleDelegate<int> dlgt = new SampleDelegate<int>(m.Square);
                Console.WriteLine("Area of the Square: " + dlgt(5));
                // Instantiate delegate with Cube method
                dlgt = m.Cube;
                Console.WriteLine("Area of Cube: " + dlgt(9));
                // Instantiate delegate with Circle method using double
                SampleDelegate<int> dlgt1 = new SampleDelegate<int>(m.Circle);
                Console.WriteLine("Area of the circle: " + dlgt1(6));

                Console.WriteLine("----------Area Using double Values---------");
                // Instantiate delegate with Square method using int
                SampleDelegate<double> dlgt3 = new SampleDelegate<double>(m.Square);
                Console.WriteLine("Area of the Square: " + dlgt3(5.2));

                // Instantiate delegate with Cube method
                SampleDelegate<double> dlgt4 = new SampleDelegate<double>(m.Cube1);
                Console.WriteLine("Area of the Cube: " + dlgt4(5.2));

                // Instantiate delegate with Circle method using double
                SampleDelegate<double> dlgt5 = new SampleDelegate<double>(m.Circle);
                Console.WriteLine("Area of the circle: " + dlgt5(6.2));

            }
        }
    }
}
