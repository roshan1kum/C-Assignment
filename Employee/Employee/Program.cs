using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name, departmentName;
            Console.WriteLine("enter the id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Name");
            name = Console.ReadLine();
            Console.WriteLine("enter the DepartmentName");
            departmentName = Console.ReadLine();

            Employee emp = new Employee(id, name, departmentName);
            emp.methodCalled += new methodDelegate(MethodCalling);
            Console.WriteLine("ID:" + emp.GetId());
            Console.WriteLine("Name:" + emp.GetName());
            Console.WriteLine("Department name:" + emp.GetDepartmentName());

            Console.WriteLine("enter the updated id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the updated Name");
            name = Console.ReadLine();
            Console.WriteLine("enter the updated DepartmentName");
            departmentName = Console.ReadLine();
            

            Console.WriteLine("updated ID:" + emp.GetId(id));
            Console.WriteLine("updated Name:" + emp.GetName(name));
            Console.WriteLine("updated Department name:" + emp.GetDepartmentName(departmentName));

        }
        static void MethodCalling(string mName)
         {
             Console.WriteLine(mName + " Method Called");
         }

    }
}
