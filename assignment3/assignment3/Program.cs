using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<products> productList= new List<products>();
            productList.Add((new products("lettuce", 10.5, 50, "Leafy green")));
            productList.Add((new products("cabbage", 20, 100, "Cruciferous")));
            productList.Add((new products("pumpkin", 30 , 30, "Marrow")));
            productList.Add((new products("cauliflower", 10, 25, "Cruciferous")));
            productList.Add((new products("zucchini", 20.5, 50, "Marrow")));
            productList.Add((new products("yam", 30, 50," Root")));
            productList.Add((new products("spinach", 10, 100, "Leafy green")));
            productList.Add((new products("broccoli",20.2 , 75," Cruciferous")));
            productList.Add((new products("garlic", 30 , 20, "Leafy green")));
            productList.Add((new products("silverbeet", 10, 50, "Marrow")));

            Console.WriteLine("total number of products: "+productList.Count);
            
            productList.Add((new products("Potato", 10, 50, "Root")));
            Console.WriteLine("\n");
            Console.WriteLine("the list of products are: ");
            foreach(var i in productList)
                {
                    Console.WriteLine("products: {0},{1},{2},{3}", i.name, i.type,i.quantity,i.price);
                }
            Console.WriteLine("\n");
            Console.WriteLine("total number of products: "+productList.Count);
            Console.WriteLine("\n");
            Console.WriteLine("the lefy green products are:");
            foreach(var i in productList)
                {
                    if(i.type=="Leafy green")
                    {
                        Console.WriteLine(i.name);
                    }
                }
            Console.WriteLine("\n");
            Console.WriteLine("All the garlic have been sold out");
            var rem = productList.SingleOrDefault(x => x.name == "garlic");
            productList.Remove(rem);
          
             Console.WriteLine("\n");
             Console.WriteLine("the list of products are: ");
            foreach(var i in productList)
                {
                    Console.WriteLine("products: {0},{1},{2},{3}", i.name, i.type,i.quantity,i.price);
                }
            Console.WriteLine("\n");
            Console.WriteLine("user add 50 cabbages in inventory");
            for (int i=0;i<productList.Count;i++)
                {
               if(productList[i].name.Equals("cabbage"))
                {
                    productList[i].quantity+=50;
                }
               }
             foreach(var i in productList)
                {
                    Console.WriteLine("products: {0},{1},{2},{3}", i.name, i.type,i.quantity,i.price);
                }
            Console.WriteLine("\n");
            Console.WriteLine("user purchases 1kg lettuce, 2 kg zucchini, 1 kg broccoli ");
            double total=0.0;
            foreach(var i in productList)
                {
               if(i.name.Equals("lettuce"))
               {
                    total+=1*i.price;
               }
               if(i.name.Equals("zucchini"))
                    {
                    total+=2*i.price;
                    }
               if(i.name.Equals("broccoli"))
               {
                    total+=1*i.price;
               }
               }
            Console.WriteLine("total price= "+total);
        }
    }
}