using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public interface A
    {
        public void Display();
    }

    public interface B
    {
        public void Display();
    }
    public class c : A, B
    {
        public void Display()
        {
            Console.WriteLine("Displaying");
        }
    }
    public interface ICategory
    {
        public bool Add();
        public void Display();
        public void Print();
    }

    public class Category :ICategory
    {
        // c# does not allow multiple inhertianc
        // we must define add and display methods here, because of strict contract
        public bool Add()
        {
            Console.WriteLine("Added");
            return true;
        }

        public void Display()
        {
            Console.WriteLine("Displaying categories");
        }

        public void Print()
        {
            Console.WriteLine("Printing");
        }

    }
    internal class Part21
    {
        static void Main()
        {
            ICategory category = new Category();
            category.Display();
            category.Add();
            category.Print();
            //c obj = new c();
            //obj.Display();


        }
    }
}
