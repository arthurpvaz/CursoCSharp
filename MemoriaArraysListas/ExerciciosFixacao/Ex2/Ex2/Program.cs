using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Employee empIdTest = employees.Find(x => x.Id == id);

                while (empIdTest != null)
                {
                    Console.WriteLine("Invalid ID! \nAlready exists");

                    Console.WriteLine($"Employee #{i}:");

                    Console.Write("Id: ");
                    id = int.Parse(Console.ReadLine());

                    empIdTest = employees.Find(x => x.Id == id);
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee ID that will have salary increase: ");
            int idTest = int.Parse(Console.ReadLine());

            Employee empTest = employees.Find(x => x.Id == idTest);

            if (empTest != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                empTest.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }

            Console.WriteLine("Updated list of employees:");

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}