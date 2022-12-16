using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class MyProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    internal class Part23
    {
       public static void Main()
        {
            // index of an array always start from zero, first element resides at 0th index
            //int[] arr1 = new int[5];
            //arr1[0] = 1;
            //arr1[1] = 4;
            //arr1[2] = 5;
            //arr1[3] = 8;
            //arr1[4] = 21;
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr1[3]);
            //Console.WriteLine(arr1[4]);

            int[] arr = { 111, 2, 4, 521, 6, 70, 18, 1, 34, 55 };
            int[] arr2 = { 7, 21 };
            int[] mergedArray = arr.Concat(arr2).ToArray();

            for (int i = 0; i < mergedArray.Length; i++)
            {
                Console.Write($"{mergedArray[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("After sorting");
            Array.Sort(mergedArray);
            for (int i = 0; i < mergedArray.Length; i++)
            {
                Console.Write($"{mergedArray[i]} ");
            }

            //Console.WriteLine(mergedArray.Contains(7));
            //Console.WriteLine(mergedArray.Contains(21));
            //Console.WriteLine(mergedArray.Contains(31));

            //string[] names = { "John", "Max", "xyx", "Jason" };
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.Write($"{names[i]} ");
            //}

            //MyProduct[] products =
            //{
            //  new MyProduct{Name="product 1",Price=39},
            //  new MyProduct{Name="product 2",Price=41},
            //  new MyProduct{Name="product 3",Price=42}
            //};
            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.Write($"Name: {products[i].Name} , Price: {products[i].Price} ");
            //    Console.WriteLine();
            //}
        }
    }
}
