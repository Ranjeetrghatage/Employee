using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Employee_service
    {
        private List<Employee> employees = new List<Employee>();    

        public void CreateEmployee()
        {

            Console.Write("Enter the employee id:");
            int id = int.Parse(Console.ReadLine());
          

            Console.Write("Enter the employee name:");
            String name = Console.ReadLine();

            Console.Write("Enter the employee designation:");
            String designation = Console.ReadLine();

            Console.Write("Enter the employee department:");
            String department = Console.ReadLine();

            Console.Write("Enter the employee salary:");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Data saved successfully");
            Console.Read();


        }

        public void ShowAllEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No Employees found");
            }
            else
            {
                Console.WriteLine("Employee Details:");
                foreach(Employee employee in employees) {
                Console.WriteLine("ID:{0},Name:{1},Designation:{2},Department:{3},salary{4}", employee.EmpID,employee.EmpName, employee.EmpDesignation, employee.EmpSalary);
                }
            }

            void DeleteEmployee(int emp_ID){
            Employee employee = employees.Find(e => e.EmpID==emp_ID);
                if (employee != null) {
                    employee.Remove(employee);
                    Console.WriteLine("Employee deleted successfully");
                }
                else
                {
                Console.WriteLine("no employee found with ID:{0} ",employee.EmpID); 
                }
            }



        }

    }
}
