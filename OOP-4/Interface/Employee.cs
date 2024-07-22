using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface
{
    internal class Employee : ICloneable , IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        //public object Clone()
        //{
        //    return new Employee()
        //    {
        //        Id = this.Id,
        //        Name = this.Name,
        //        Salary = this.Salary
        //    };
        //}

        public object Clone()
        {
            return new Employee(this);
   
        }
        public Employee(Employee employee)
        { 
            Id=employee.Id;
            Name=employee.Name;
            Salary=employee.Salary;
        }
        public Employee() 
        { }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee passedEmployee = (Employee)obj;
            if (this.Salary > passedEmployee.Salary)
            {
                return 1;
            }
            else if (this.Salary < passedEmployee.Salary)
            {
                return -1;
            }
            else { 
            return 0;
            }
        }
    }
}
