using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class Part5
    {
        public static void Main()
        {

            // if
            Console.Write("Enter any number :");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 6)
            {
                Console.WriteLine("Number is less than 6");
            }
            else if (x == 6)
            {
                Console.WriteLine("Number is 6");
            }
            else if (x == 7)
            {
                Console.WriteLine("Number is 7");

            }
            else if (x == 8)
            {
                Console.WriteLine("Number is 8");

            }

            else
            {
                Console.WriteLine("Number is greater than 8");
            }
        }
    }
}
