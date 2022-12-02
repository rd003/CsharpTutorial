using CsharpTutorialLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    //public  class PrivateClass{
        
         
    //    }

    public class MyDrawing
    {
        protected void Draw()
        {
            Console.WriteLine("I m drawing");
        }
    }
    public class Part17 : MyPublicClass
    {
        //private void Display()
        //{
        //    Console.WriteLine("displaying as a private member");
        //}
        static void Main()
        {
            //MyPublicClass obj1 = new MyPublicClass();
            Part17 pr = new Part17();
            pr.ProtectedInternalDisplay();
            // pr.Display();
           // pr.Draw();

            //MyPublicClass obj = new MyPublicClass();
            //obj.ProtectedInternalDisplay();

        }
    }
}
