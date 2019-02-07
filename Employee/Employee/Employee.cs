using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public event methodDelegate methodCalled;
        private int ID
        {
            get; set;
        }
        private string Name
        {
            get; set;
        }
        private string DepartmentName
        {
            get; set;
        }
        public Employee(int ID, string Name, string DepartmentName)
        {
            this.ID = ID;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }
        public int GetId()
        {
            methodCalled("GetID");
            return ID;

        }
        public string GetName()
        {
            methodCalled("GetName");
            return Name;
        }
        public string GetDepartmentName()
        {
            methodCalled("GetDepartmentName");
            return DepartmentName;
        }
        public void UpdateProperty(int id)
        {
            ID = id;
        }
        public void UpdateProperty(int id,string name)
        {
            ID = id;
            Name = name;
        }
        public void UpdateProperty(int id,string name,string dept)
        {
            ID = id;
            Name = name;
            DepartmentName = dept;
        }
        
    }
}
