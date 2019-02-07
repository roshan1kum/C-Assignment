using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the designation");
            string des = Console.ReadLine();
            Console.WriteLine("enter the experience");
            int exp = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the annual salary:");
            int asalary =int.Parse(Console.ReadLine());
            Console.WriteLine("enter the joining date:");
            int dt =int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the basic salary");
            //int basic = int.Parse(Console.ReadLine());
            HR h = new HR(name,des,exp,asalary,dt);
            Developer d = new Developer("roshan", "dev", 5, 240000, 1);
            h.salary();
            d.salary();
        }
    }
}
