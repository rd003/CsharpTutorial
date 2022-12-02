using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Person
    {
        public string name;
        public int age;

        // constructor : 
            //it has the same name as Class
            // does not contain any return type
        public Person()
        {
            Console.WriteLine("Constructor called");
        }

        public Person(string pName,int pAge)
        {
            name = pName;
            age = pAge;
        }
        public void DispayPerson()
        {
            Console.WriteLine($"name: {name} , age: {age}");
        }
    }
    public class part13
    {
        static void Main()
        {
            Person p = new Person("John", 30);
            p.DispayPerson();
            Person p2 = new Person("Max", 50);
            p2.DispayPerson();
            //Person p1 = new Person();
            //p1.DispayPerson();
        }
    }
}
