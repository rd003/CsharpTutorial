using System;
using System.Collections.Generic;


namespace CsharpTutorial
{
    internal class part25
    {
        //Hashset<T>
        static void Main()
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1); 
            hs.Add(1); 
            hs.Add(3); 
            hs.Add(2); 
            hs.Add(2); 
            hs.Add(2); 
            hs.Add(2);
            hs.Add(4);
            hs.Add(5);
            hs.Remove(3);
            hs.Remove(1);
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
        }
        //Dictionary<k,v>
        //static void Main()
        //{
        //    Dictionary<int, string> obj = new Dictionary<int, string>();
        //    obj.Add(1, "John");
        //    obj.Add(2, "Max");
        //    obj.Add(6, "Marry");
        //    obj.Add(4, "Harry");
        //    obj.Add(5, "Jerry");
        //    //obj.Remove(4);
        //    // obj.Clear();
        //    //var itemHarry = new KeyValuePair<int, string>(4, "harry");
        //    //Console.WriteLine(obj.Contains(itemHarry));
        //    Console.WriteLine(obj.ContainsValue("jackson"));
        //    foreach (KeyValuePair<int,string> kv in obj)
        //    {
        //        Console.WriteLine($"key: {kv.Key} and value: {kv.Value}");
        //    }
        //}

        // list<t>
        //static void Main()
        //{
        //    List<string> list = new List<string>();
        //    list.Add("hello");
        //    list.Add("there");
        //    list.Add("everyone");
        //    list.Add("......");
        //    list[3] = "How are you?";
        //    //list.ForEach((item) =>
        //    //{
        //    //    Console.WriteLine(item);
        //    //});
        //    //list.Clear(); //removes all items
        //    Console.WriteLine(list.Find(a=>a.ToLower().Contains("eve")));
        //    //foreach (var item in list)
        //    //{
        //    //    Console.WriteLine(item);
        //    //}
            

        //}

        //// hashtables
        //static void Main()
        //{
        //    Hashtable ht = new Hashtable();
        //    ht.Add(1, "John");
        //    ht.Add("1", "John");
        //    ht.Add(1.1, "Max");
        //    ht.Add(1.2, "Mary");
        //    ht.Add(true, 45);
        //    ht.Add(false, true);
        //    foreach(DictionaryEntry de in ht)
        //    {
        //        Console.WriteLine($"key: {de.Key} | value: {de.Value}");
        //    }
        //    Console.WriteLine(ht.ContainsKey(1.1));
        //    Console.WriteLine(ht.ContainsKey(45));
        //}


        // array list example
        //static void Main()
        //{
        //    // array list
        //    ArrayList arrList = new ArrayList();
        //    arrList.Add(1);
        //    arrList.Add("john");
        //    arrList.Add('x');
        //    arrList.Add(true);
        //    arrList.Add(2.5);
        //    arrList.Add(null);
        //    int[] values =  { 3, 2, 4 };
        //    string[] names =  { "name1", "name2", "name3" };
        //    arrList.AddRange(values);
        //    //arrList.AddRange(names);
        //    arrList.Insert(1, "index 1 new value");
        //    arrList.InsertRange(2, names);
        //    foreach (var item in arrList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("After removing 3rd value");
        //    //arrList.Remove(1);
        //    arrList.RemoveAt(3);
         
        //    foreach (var item in arrList)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}
    }
}
