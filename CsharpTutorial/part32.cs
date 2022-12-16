using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    internal class part32
    {
        public static int PrintA()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"A{i}");
            }
            Thread.Sleep(5000);
            return 1;
        }


        public static async Task<int> PrintB()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"A{i}");
            }
            await Task.Delay(5000);
            return 1;
        }



        static async Task Main(string[] args)
        {
            //int taskA = PrintA();
            //Console.WriteLine("i am outside from task A");
            //Console.WriteLine("i am also outside from task A");
            //Console.WriteLine($"Result of task A is {taskA}");

            Task<int> taskB = PrintB();
            Console.WriteLine("i am outside from task B");
            Console.WriteLine("i am also outside from task B");
            await taskB;
            Console.WriteLine($"Result of task A is {taskB.Result}");
        }
    }
}
