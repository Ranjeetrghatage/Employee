using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee_service Employee_service = new Employee_service();
        


            Console.WriteLine("Please choose any one of the option from below list:");
            Console.WriteLine("1. Create Employee\n2. Delete Employee\n3. Display Employee\n4. Exit ");
            Console.Write("Enter your choice from the above list mentioned:");
            int entered_number = int.Parse(Console.ReadLine());

            if (entered_number == 1)
            {

                Console.WriteLine("You have choosen to create the employee");
                Console.Write("Tell me how many employees you want to create: ");
                int emp_number=int.Parse(Console.ReadLine());
                for (int i = 1; i <=emp_number; i++)
                {
                    Console.WriteLine("You are creating the details of the employee: " + i);
                    Employee_service.CreateEmployee();
                    Console.ReadLine();
                }
               
            }
            else if (entered_number == 2)
            {
                Console.Write("Enter the employee to be deleted:");
                int ID=int.Parse(Console.ReadLine());

                

            }
            else if (entered_number == 3)
            {
                Console.Write("Displaying the employees:");
                Employee_service.ShowAllEmployees();
                Console.ReadLine(); 
            }
            else if (entered_number == 4)
            {
                Console.WriteLine("Exit");
            }
            else
            {
                Console.WriteLine("please enter the number between range '1 - 4' ");
                Console.ReadLine();
            }









        }
    }
}
