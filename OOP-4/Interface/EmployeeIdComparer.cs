using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface
{
    internal class EmployeeIdComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee?employeeX = (Employee?)x;
            Employee?employeeY = (Employee?)y;
            //if (employeeX.Id > employeeY.Id) 
            //    return 1;
            //else if (employeeX.Id < employeeY.Id)
            //    return -1;
            //return 0;
            return employeeX?.Id.CompareTo(employeeY?.Id)??(employeeY is null ? 0 : -1);  

        }
    }
}
