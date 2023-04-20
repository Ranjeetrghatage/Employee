using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Employee
    {
        public int EmpID { get; set; }

        public String EmpName { get; set; }

        public string EmpDesignation { get; set; }

        public float EmpSalary { get; set; }    

        public string EmpDepartment { get; set; }

        internal void Remove(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
