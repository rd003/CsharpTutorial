using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Calculator
    {
        public int Sum(int x,int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return x / y;
        }

        public string CheckEven(int num)
        {
            if (num % 2 == 0)
                return "It is Even nubmer";
            else
                return "It is odd number";
        }

    }
    public class Employee
    {
        public string name;
        public double salary;
        public DateTime doj;
        public void GetEmployeeDetails()
        {
            Console.WriteLine($"name :{name} salary: {salary} doj: {doj}");
        }
        public Employee(string ename,double esalary,DateTime edoj) {
            name = ename;
            salary = esalary;
            doj = edoj;
        }
    }
    internal class part14
    {
        static void Main()
        {
            //prog 1
            //Employee emp = new Employee("john",3000,DateTime.Now);
            //emp.GetEmployeeDetails();

            //prog 2
            //Calculator calc = new Calculator();
            //int x = 9; int y = 3;
            //int sum = calc.Sum(x, y);
            //int sub = calc.Sub(x, y);
            //int mul = calc.Mul(x, y);
            //int div = calc.Division(x, y);
            //Console.WriteLine($"sum of {x} and {y} is {sum}");
            //Console.WriteLine($"subtract of {x} and {y} is {sub}");
            //Console.WriteLine($"multiplication of {x} and {y} is {mul}");
            //Console.WriteLine($"division of {x} and {y} is {div}");

            // prog3
            var calc = new Calculator();
            Console.WriteLine(calc.CheckEven(5));

        }
    }
}
