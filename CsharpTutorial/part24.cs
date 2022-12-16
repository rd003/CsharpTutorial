using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class part24
    {
        static void Main()
        {
            int a = 5;
            object obj = a;
            Console.WriteLine(obj);
            int b = (int)obj;
            Console.WriteLine(b);
        }
    }
}
