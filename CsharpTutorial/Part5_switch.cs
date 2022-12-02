using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class Part5_switch
    {
        public static void Main()
        {

            // if
            Console.Write("Enter any number :");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 0:
                    Console.WriteLine("number is 0");
                    break;
                case 1:
                    Console.WriteLine("number is 1");
                    break;
                case 2:
                    Console.WriteLine("number is 2");
                    break;
                case 3:
                    Console.WriteLine("number is 3");
                    break;
                case 4:
                    Console.WriteLine("number is 4");
                    break;
                default:
                    Console.WriteLine("number is greater than 4");
                    break;
            }
        }
    }
}
