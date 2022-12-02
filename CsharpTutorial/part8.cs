using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class part8
    {
        static void Main()
        {
            string s = "hello";
            string str = @"
                I
                am
                Ravindra ";
            IEnumerable<char> newStr = s.Concat(str);
            foreach(char c in newStr)
            {
                Console.Write(c);
            }
            // find the length of string
            int len = s.Length;
            Console.WriteLine($"length of {s} is : {len}");
            Console.WriteLine(s[len-1]);
        }
    }
}
