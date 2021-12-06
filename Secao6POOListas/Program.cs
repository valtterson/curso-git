using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Secao6POOListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employee will be registered?");
            int number = int.Parse(Console.ReadLine());

            List<Employee> emp = new List<Employee>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Employee #" + i);

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Enter the employeee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee employee = emp.Find(x => x.Id == searchId);

            if (employee == null)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.WriteLine("Enter the porcentage:");
                double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(porcentage);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Updated list of employee:");

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.Id + ", " + e.Name + ", " + e.Salary.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
