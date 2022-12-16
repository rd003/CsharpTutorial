using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    delegate int SumDel(int n1, int n2);
    internal class part29
    {
        //public static int Sum(int a,int b)
        //{
        //    return a + b;
        //}
        public static void PrintSum(int a,int b, SumDel delHandler )
        {
           Console.WriteLine($"Sum of {a} and {b} is {delHandler(a,b)}");
        }
        static void Main()
        {
            //SumDel sumHandler = Sum;

           // using anonymous methods
            SumDel sumHandler = delegate (int a, int b)
            {
                return a + b;

            };
            PrintSum(4, 8, sumHandler);

            //using lamda functions
            SumDel sumHandler1 = (a, b) => { return a + b; };
            PrintSum(3, 9, sumHandler1);
        }
    }
}
