using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public static class Utility
    {
        public static void SendEmail()
        {
            Console.WriteLine("Sending email");
        }

        public static void Print()
        {
            Console.WriteLine("Printing...");
        }
    }
   
    internal class Part19
    {
        static int count = 0;
        public Part19()
        {
            count++;
        }
        public static int Sum(int a,int b)
        {
            return a + b;
        }
        public void Print()
        {
            Console.WriteLine(count) ;
        }
        static void Main()
        {
            // accessig static method
            Console.WriteLine(Part19.Sum(3, 5));

            //accessing regular method
            Part19 obj = new Part19();
            obj.Print();
            Part19 obj1 = new Part19();
            obj1.Print();
            Part19 obj2 = new Part19();
            obj2.Print();

            Utility.Print();
            Utility.SendEmail();
        }
    }
}
