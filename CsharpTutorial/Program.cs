// See https://aka.ms/new-console-template for more information

// author: Ravindra

/*
   author: ravindra
   course : c#
   platform: yt
   etc
 */
//Console.WriteLine("Hello, there!");
namespace part2
{
    class Program
    {
        readonly int y = 5;
        public Program()
        {
            y = 6;

        }
        static void Main(string[] args)
        {
           
            // main method is the first method, gets executed in application
            // entry point
            int a = 1;   // a is a variable , int is a datatype
                         //double d = 2.5;
                         //float f = 2.5f;
                         //char c = 'x';
                         //DateTime dt = DateTime.Now;
                         //bool b = true;  //true or false
            a = 3;
            const int x = 4;  //fixed
            Program p =new Program();
            
            Console.WriteLine(a);
            Console.WriteLine(x);
            Console.WriteLine(p.y);
            //Console.WriteLine(d);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(dt);
        }
    }
}

