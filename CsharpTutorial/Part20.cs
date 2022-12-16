using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public abstract class Employee1
    {
        int sal;
        public double GetMinimumSal()
        {
            return sal;
        }

        public abstract double CalculateBonus();
       
    }
    // PermanentEmployee 10%, TemproryEmployee 5%
    public abstract class Shape1
    {
        int x;
        public abstract void Draw();
        public abstract void Draw2();
        public void Print()
        {
            Console.WriteLine("Printing....");
        }
    }
    internal class Part20 : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Draw 1");
        }
        public override void Draw2()
        {
            Console.WriteLine("Draw 2");
        }
        static void Main()
        {
            Part20 obj = new Part20();
            obj.Print();
            obj.Draw();
            obj.Draw2();
        }
    }
}
