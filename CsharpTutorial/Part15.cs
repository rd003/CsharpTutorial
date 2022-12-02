using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTutorial
{
    public class Employee
    {
        //base class
        public int id;
        public string name;
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Employee() { }
        public void DisplayEmployee()
        {
            Console.WriteLine($"id: {id} name: {name}");
        }
    }

    public class Programmer : Employee
    {
        //derived
        public void GetCoffee()
        {
            Console.WriteLine("Getting coffee");
        }
        public Programmer(int id,string name) : base(id,name)
        {

        }
    }
    public class Manager: Employee
    {

        //derived class
        public Manager(int id, string name) : base(id, name)
        {

        }
        public void AssignTask()
        {
            Console.WriteLine("Assigning task");
        }
    }
    internal class Part15
    {
        static void Main()
        {
            Employee emp = new Employee(1, "john");
            emp.DisplayEmployee();
            Programmer prg = new Programmer(11, "jill");
            prg.DisplayEmployee();
            prg.GetCoffee();
            Manager mgr = new Manager(3, "Max");
            mgr.AssignTask();
            mgr.DisplayEmployee();

        }
    }
}
