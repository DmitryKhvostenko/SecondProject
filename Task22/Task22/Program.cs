using System;
namespace Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Dima\Desktop\Учеба\ООП\Task22\Task22\ListEmployee.txt";
            List<Employee> employees = new List<Employee>();
            List<string> temp = new List<string>();
            string[] list = File.ReadAllLines(path);
            foreach (var str in list)
            {
                temp.AddRange(str.Split(' '));
                employees.Add(new Employee
                {
                    Surname = temp[0],
                    Salary = Convert.ToInt32(temp[1]),
                });
                temp.Clear();
            }
            Console.WriteLine("List of employees before sorting by salary:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Surname} - {employee.Salary}");
            }
            Console.WriteLine("List of employees after sorting by salary:");
            employees.Sort((employee1, employee2) => employee2.Salary.CompareTo(employee1.Salary));
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Surname} - {employee.Salary}");
            }
        }
    }
}