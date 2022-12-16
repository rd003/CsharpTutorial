using System;
using System.Threading;

namespace CsharpTutorial
{
    internal class part31
    {
        static void Print1()
        {
           for(int i = 1; i <=5; i++)
            {
                Console.WriteLine("Method1 - "+i);
                if (i == 3)
                {
                    Thread.Sleep(3000);
                }
            }
        }

        static void Print2()
        {
            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine("Method2 - " + i);
            }
        }
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(Print1));
            Thread t2 = new Thread(new ThreadStart(Print2));
            t1.Start();
            t2.Start();
           
        }
    }
}
