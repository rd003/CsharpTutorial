using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Fruit
    {
        private string[] names = new string[10];
        public string this [int i] {
            get
            {
                return names[i];
            }
            set { 
                names[i] = value; 
            }
        }
    }

    internal class part28
    {
        public static void Main()
        {
            Fruit fruit= new Fruit();
            fruit[0] = "apple";
            fruit[1] = "banana";
            fruit[2] = "orange";
            fruit[3] = "mango";
            fruit[4] = "kiwi";
            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }
    }
}
