using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    
    internal class part30
    {
        public static void CheckGreaterThan7(int num,Predicate<int> handler)
        {
           var result= handler(num);
            Console.WriteLine(result);
        }
        public static void PrintSum(int a,int b, Func<int,int,int> delHandler )
        {
           Console.WriteLine($"Sum of {a} and {b} is {delHandler(a,b)}");
        }

        public static void Greet(string message,Action<string> greetHandler)
        {
            greetHandler(message);  //this greet handler will print the message
        }
        static void Main()
        {
            Func<int, int, int> sumHandler = (a, b) =>
            {
                return a + b;
            };
            PrintSum(3, 9, sumHandler);

            Action<string> greetHandler = (msg) =>
            {
                Console.WriteLine(msg);
            };
            Greet("Hello world! ",greetHandler);

            //predicate
            //Predicate<int> predHandler = (num) =>
            //{
            //    return num > 7;
            //};

            //CheckGreaterThan7(8, predHandler);
            CheckGreaterThan7(7, a => a > 7);

           
           
        }
    }
}
