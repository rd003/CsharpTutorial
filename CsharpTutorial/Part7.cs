using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class Part7
    {
        static void Main()
        {

            //break
            //for(int i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    goto find;
                }
                Console.WriteLine(i);
            }
        find:
            Console.WriteLine("Jumped out of the loop");
        }
    }
}
