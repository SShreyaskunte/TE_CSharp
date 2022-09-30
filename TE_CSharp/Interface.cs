using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    interface ITraining
    {
        string Course { get; set; }
        void CourseDetails();
        void Message();


    }

    interface ITraniees
    {
        int Strength { get; set; }
        void TotalTraniees();
        void Message();

    }

    public class  CSharpTraining: ITraining, ITraniees
    {
        public string Course { get; set; }
        public void CourseDetails()
        {
            Console.WriteLine($"Course : {Course}");
        }

        public int Strength { get; set; }
        public void TotalTraniees()
        {
            Console.WriteLine($"Strength : {Strength}");
        }

        void ITraining.Message()
        {
            Console.WriteLine("ITraining Message");
        }

        void ITraniees.Message()
        {
            Console.WriteLine("ITraniees Message");
        }
    }

    public class DestructorDispose:IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose : Memory cleanup done");
        }
    }
    internal class Interface
    {
        public static void Main()
        {
            ConsoleColor consoleColor = ConsoleColor.Green;
            CSharpTraining c = new CSharpTraining();
            c.Course = "C#";
            c.CourseDetails();
            c.Strength = 38;
            c.TotalTraniees();
            ITraining training = new CSharpTraining();
            training.Message();
            ITraniees trinee = new CSharpTraining();
            trinee.Message();
            DestructorDispose d = new DestructorDispose();
            d.Dispose();
        }
    }
}
