using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class Part11
    {
       static void Main()
        {
            //snake water gun
            Console.WriteLine("**** Snake , water , gun ****");
            char comp = '\0';
            //Random rnd = new Random();
            var rnd = new Random();
            var str = "swg";
            var rndIndex = rnd.Next(str.Length);
            comp = str[rndIndex];

            Console.Write("Enter 's' / 'w' / 'g' : ");
            char user = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Computer : {comp} | User: {user} ");
            // logic
            if(comp==user)
            {
                Console.WriteLine("Draw");
            }
            if (comp == 's' && user == 'w')
            {
                Console.WriteLine("computer wins");
            }

            if (comp == 's' && user == 'g')
            {
                Console.WriteLine("user wins");
            }
            if (comp == 'w' && user == 's')
            {
                Console.WriteLine("user wins");
            }
            if (comp == 'w' && user == 'g')
            {
                Console.WriteLine("computer wins");
            }
            if (comp == 'g' && user == 's')
            {
                Console.WriteLine("computer wins");
            }
            if (comp == 'g' && user == 'w')
            {
                Console.WriteLine("user wins");
            }

        }
    }
}
