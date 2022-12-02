using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class part9_1
    {
        static void Main()
        {
            // program 1
            //int a, b, c;
            //a = 5;
            //b = 6;
            //c = 7;
            //int d = a * b * c;
            //Console.WriteLine($"multiplication of {a},{b},{c} is {d}");

            //2
            //double n1 = 5;
            //double n2 = 10;
            //double avg = (n1 + n2) / 2;
            //Console.WriteLine($"avg of {n1} and {n2} is {avg}");

            //3
            //Console.WriteLine("Enter any number: ");
            //int num;
            //num = Convert.ToInt32(Console.ReadLine());
            //if (num < 0)
            //{
            //    Console.WriteLine("We do not accept negative values");
            //}

            //4
            //for(int i = 1; i <= 4; i++)
            //{
            //    Console.WriteLine("**");
            //}

            //5
            //string name = "JOHN DOE";
            //Console.WriteLine(name.Length);

            //6
            //int x = 0;
            //while (x < 10)
            //{
            //    x++;
            //    if (x == 6)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(x);

            //}
            for(int i = 1; i <= 10; i++)
            {
                if (i == 6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
