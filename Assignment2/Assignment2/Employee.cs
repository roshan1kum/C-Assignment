using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Employee
    {
        public int ID
        {
            set;
            get;
        }
        protected string name { set; get; }
        protected string Designation { set; get; }
        protected int Experience { set; get; }
        protected int annual_Salary { set; get; }
        protected int joining_date { set; get; }
        public abstract void salary();
        //public abstract void get_Employee();
        


    }
}
