using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public static class Extensions
    {
       // Extension method
        public static int MyCount(this string s)
        {
            return s.Length;
        }
    }
    internal class part26
    {
        static void Main()
        {
            string str = "Hello";
            Console.WriteLine(str.MyCount());
        }
    }
}
