using System;
using School;

namespace CsharpTutorial
{
    public class Car
    {
        // fields or data members
        public string make;
        public string model;
        public string color;
        public int year;
        public int price;
        // methods
        public void Start()
        {
            Console.WriteLine("Car is started");
        }
        public void Stop()
        {
            Console.WriteLine("Car is stopped");
        }

        public void Run()
        {
            Console.WriteLine("Car is running");
        }

    }
    internal class part12
    {
        static void Main()
        {
            //Car car = new Car();  // car=object
            //car.model = "xyz";
            //car.make = "make11";
            //car.year = 2021;
            //car.price = 150000;
            //Console.WriteLine($"model:{car.model} make: {car.make} year: {car.year} price: {car.price} ");
            //car.Start();
            //car.Run();
            //car.Stop();

            Student stu = new Student();
            stu.Display();
            Department dept = new Department();
            dept.Display();
            Teacher teacher = new Teacher();
            teacher.Display();


        }
    }
}
