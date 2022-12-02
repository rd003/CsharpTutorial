using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Product
    {
        //private string name;
        //private double price;

        public double Price { get; set; }
        public string Name { get; set; }

        //public double Price
        //{
        //    get { return price; }
        //    set {
        //        if (value < 0)
        //        {
        //            throw new Exception("Cant accept negetive values");
        //        }
        //        price = value; 
        //    }
        //}

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}

        //public void SetPrice(double price)
        //{
        //    if(price < 0)
        //    {
        //        throw new Exception("Price cant be negetive");
        //    }
        //    this.price = price;
        //}

        //public double GetPrice()
        //{
        //    return this.price;
        //}

    }
    internal class Part18
    {
        static void Main()
        {
            Product product = new Product();
            // product.SetPrice(-15000);
            //Console.WriteLine(product.name);
            product.Price = 100;
            Console.WriteLine(product.Price);
        }
    }
}
