using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am drawing shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am drawing circle");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am drawing square");
        }
    }
    internal class Part16
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine($"sum is {a + b}");
        }

        public void Sum(int a, int b,int c)
        {
            Console.WriteLine($"sum is {a + b+c}");
        }
        static void Main()
        {
            // method overloading section
            //Part16 obj = new Part16();
            //obj.Sum(1, 2);
            //obj.Sum(1, 2,7);

            // method overriding
            Shape sh = new Shape();
            sh.Draw();
            Shape circle = new Circle();
            circle.Draw();
            Shape sq = new Square();
            sq.Draw();
        }
    }
}
