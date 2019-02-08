using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>()
            {
                { "Atal Bihari Vajpayee", 1998 },
                { "Narendra Modi", 2014},
                { "Manmohan Singh", 2004 }
            };
            Console.WriteLine("prime minister of 2004 is:");
            foreach(var i in dict)
            {
                if(i.Value==2004)
                Console.WriteLine(i.Key);
            }
            dict.Add("MS DHONI", 2019);
            Console.WriteLine("\n");
            Console.WriteLine("the sorted dcictionary by year is :");
            var result = from v in dict
                         orderby v.Value ascending
                         select v;
            foreach(var i in result)
            {
                Console.WriteLine(i.Key+" "+i.Value);
            }
        }
    }
}
