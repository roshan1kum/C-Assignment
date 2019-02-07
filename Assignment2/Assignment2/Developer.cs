using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Developer:Employee
    {
        int basic_salary=8000;
        public Developer(string name, string Designation, int Experience, int annual_Salary, int joining_date)
        {
            this.name = name;
            this.Designation = Designation;
            this.Experience = Experience;
            this.annual_Salary = annual_Salary;
            this.joining_date = joining_date;
            //this.basic_salary = basic_salary;
        }
        public override void salary()
        {
            int total = basic_salary + (2000 * Experience);
            Console.WriteLine("salary of developer:" + total);
        }
    }
}
