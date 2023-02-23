using System;
namespace Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Dima\Desktop\Учеба\ООП\Task21\Task21\listofstudents.txt";
            List<Student> students = new List<Student>();
            List<string> parts = new List<string>();
            string[] list = File.ReadAllLines(path);
            foreach (var str in list)
            {
                parts.AddRange(str.Split(' '));
                students.Add(new Student
                {
                    Name = parts[0],
                    Mark1 = Convert.ToInt32(parts[1]),
                    Mark2 = Convert.ToInt32(parts[2]),
                    Average = (Convert.ToInt32(parts[1]) + Convert.ToInt32(parts[2])) / 2,
                });
                parts.Clear();
            }
            Console.WriteLine("List of avarage students before filtering:");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Average}");
            }
            Console.WriteLine("List of avarage students after filtering:");
            List<Student> filteredStudents = students.OrderByDescending(s => s.Average).ToList();
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Average}");
            }
        }
    }
}