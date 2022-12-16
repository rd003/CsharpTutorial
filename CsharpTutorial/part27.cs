using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public enum Weeks
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };
    internal class part27
    {
       
       static void Main()
        {
            Console.WriteLine((int)Weeks.Monday);
            Console.WriteLine((int)Weeks.Friday);

        }
    }
}
