using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part22
    {
        public static void Main()
        {
            try
            {
                int a = 6;
                int b = 2;
                Console.WriteLine(a / b);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I m from finally block");
            }
            Console.WriteLine("Divided successfully");

        }
    }

}
