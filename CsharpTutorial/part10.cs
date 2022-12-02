using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class part10
    {
        static void Main()
        {
            //program 1
            //for(int i = 1; i <= 5; i++)
            // {
            //     //i=1 , j=1 *
            //     //i=1,j=2
            //     //i=2, j=1 *
            //     //i=2, j=2 **
            //     //i=2, j=3
            //     // i=3 => ***
            //     for(int j = 1; j <= i; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }

            // prog 2 : even or odd

            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            // logic part
            // if we do not have any remainder after dividing a number by 2,then its even number
            // 4/2=0(rem) even 5/2=1(rem) odd
            // modulos operator 4%2=0
            if (num % 2 == 0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            }
        }
    }
}
