using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment6
{
    class Program
    {
        List<Employee> employeeList;
        List<Salary> salaryList;

        public Program()
        {
            employeeList = new List<Employee>() {
            new Employee(){ EmployeeID = 1, EmployeeFirstName = "Rajiv", EmployeeLastName = "Desai", Age = 49},
            new Employee(){ EmployeeID = 2, EmployeeFirstName = "Karan", EmployeeLastName = "Patel", Age = 32},
            new Employee(){ EmployeeID = 3, EmployeeFirstName = "Sujit", EmployeeLastName = "Dixit", Age = 28},
            new Employee(){ EmployeeID = 4, EmployeeFirstName = "Mahendra", EmployeeLastName = "Suri", Age = 26},
            new Employee(){ EmployeeID = 5, EmployeeFirstName = "Divya", EmployeeLastName = "Das", Age = 20},
            new Employee(){ EmployeeID = 6, EmployeeFirstName = "Ridhi", EmployeeLastName = "Shah", Age = 60},
            new Employee(){ EmployeeID = 7, EmployeeFirstName = "Dimple", EmployeeLastName = "Bhatt", Age = 53}
        };

            salaryList = new List<Salary>() {
            new Salary(){ EmployeeID = 1, Amount = 1000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 1, Amount = 500, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 1, Amount = 100, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 2, Amount = 3000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 2, Amount = 1000, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 3, Amount = 1500, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 4, Amount = 2100, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 5, Amount = 2800, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 5, Amount = 600, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 5, Amount = 500, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 6, Amount = 3000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 6, Amount = 400, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 7, Amount = 4700, Type = SalaryType.Monthly}
        };
        }

        public static void Main()
        {
            Program program = new Program();

            program.Task1();

            program.Task2();

            program.Task3();
        }

        public void Task1()
        {
            Dictionary<string, int> ar = new Dictionary<string, int>();
            //Implementation
            var query = from salary in salaryList
                        join employee in employeeList
                        on salary.EmployeeID equals employee.EmployeeID
                        select new
                        {
                            employee.EmployeeFirstName,
                            salary.EmployeeID,
                            salary.Amount
                        };
            var query2 = from q in query
                         group q by q.EmployeeFirstName;


            foreach(var i in query2)
            {
                //Console.WriteLine(i.Key);
               // var k = i.Key;
                var a = 0;
                foreach(var s in i)
                {
                    a += s.Amount;
                   // Console.WriteLine(s.Amount);
                }
                ar.Add(i.Key, a);
               // Console.WriteLine(a);
            }
            var items = from pair in ar
                        orderby pair.Value ascending
                        select pair;

            // Display results.
            Console.WriteLine("\nSalary of all the employee with their corresponding names in ascending order of their salary:");
            foreach (KeyValuePair<string, int> pair in items)
            {
                
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
        public void Task2()
        {
            //Implementation
            var query = from salary in salaryList
                        join employee in employeeList
                        on salary.EmployeeID equals employee.EmployeeID
                        where salary.Type == SalaryType.Monthly
                        orderby employee.Age descending
                        select new
                        {
                            employee.EmployeeFirstName,
                            employee.EmployeeLastName,
                            employee.EmployeeID,
                            employee.Age,
                            salary.Amount,
                            salary.Type
                        };

            var query2 = from q in query
                         group q by q.EmployeeFirstName;
                      
            Console.WriteLine("\n");
            foreach (var i in query2.Take(2).Skip(1))
            {
                //Console.WriteLine(i.Key+" ");
                foreach(var s in i)
                {
                    Console.WriteLine("Second oldest Employee details is :");
                    Console.WriteLine(i.Key+" "+s.EmployeeLastName+" "+s.EmployeeID+" "+s.Amount+" "+s.Age+" "+s.Type);
                }
            }
        }

        public void Task3()
        {
            //Implementation
            var query = from salary in salaryList
                        join employee in employeeList
                        on salary.EmployeeID equals employee.EmployeeID
                        where employee.Age > 30
                        select new
                        {
                            salary.Amount,
                            employee.EmployeeFirstName,
  
                        };
            var query2 = from q in query
                         group q by q.EmployeeFirstName into query3
                         select new{
                                        MonthlyMean=query3.Average(c=>c.Amount),
                                        name=query3.Key
                                   };
            Console.WriteLine("\nMean of Monthly, Performance, Bonus salary of employees whose age is greater than 30 is:");
            foreach(var i in query2)
            {
                Console.WriteLine($"{i.name } : {i.MonthlyMean}");
            }

        }
    }
    public enum SalaryType
    {
        Monthly,
        Performance,
        Bonus
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int Age { get; set; }
    }

    public class Salary
    {
        public int EmployeeID { get; set; }
        public int Amount { get; set; }
        public SalaryType Type { get; set; }
    }
}
