using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    public class Employee
    {
        string surname="";
        int salary;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Employee(string surname, int salary)
        {
            Surname = surname;
            Salary = salary;
        }
        public Employee() { }
    }
}
