using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class Part4
    {
       public static void Main()
        {
            // operator
            // arithmatic ops
            int a = 15;
            int b = 6;
            int sum = a + b;
            int minus = a - b;
            int mul = a * b;
            int div = a / b;
            int per = a % b;  // modulas operator, it gives us remainder
            int c = ++a; // it increments the value by one
            int d = --a; // it decrements the value by one

            int x = 5, z = 5;
            bool cNum = a == b;

            //bool lNum = x==5 || z == 6;
            bool lNum = x != 5;

            x *= 6; //x = x*6 // 5*6=30
            Console.WriteLine(x);

        }
    }
}
