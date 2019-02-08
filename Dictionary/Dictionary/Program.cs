using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] arr = { "Boat", "house", "cat", "river", "cupboard" }
            var array = new List<string>() { "Boat", "house", "cat", "river", "cupboard" };
            query q = new query(array);
            Console.WriteLine("the plural of all words are:");
            q.plural();
            array[1] = "apartment";
            Console.WriteLine("\n");
            Console.WriteLine("the list are:");
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
            array.Add("lengths");
            Console.WriteLine("the length of the list is:" + array.Count);
            Console.WriteLine("\n");
            Console.WriteLine("enter the  length of characters");
            int n = int.Parse(Console.ReadLine());
            var result = array.Where(s => s.Length == n);
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("the word on 3rd position are:");
            Console.WriteLine(array[2]);
            Console.WriteLine("\n");
            Console.WriteLine("the word in ascending are:");
            var asce = from s in array
                         orderby s ascending
                         select s;
            foreach(var i in asce)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("the reverse word are :");
            var rev = array.OrderByDescending(a => a);
            foreach(var i in rev)
            {
                Console.WriteLine(i);
           }
        }
    }
}