using System;
namespace Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Dima\Desktop\Учеба\ООП\Task23\Task23\listTransport.txt";
            List<Transport> transports = new List<Transport>();
            List<string> temp = new List<string>();
            string[] list = File.ReadAllLines(path);
            foreach (var str in list)
            {
                temp.AddRange(str.Split(' '));
                transports.Add(new Transport(temp[0], temp[1]));
                temp.Clear();
            }
            foreach (Transport transport in transports)
            {
                Console.WriteLine($"{transport.Name} - {transport.Category}");
            }
            Console.WriteLine("List after grouping:");
            var groupedProducts = transports.GroupBy(p => p.Category);
            foreach (var group in groupedProducts)
            {
                Console.WriteLine(group.Key);
                foreach (var transport in group)
                {
                    Console.WriteLine("  " + transport.Name);
                }
            }
        }
    }
}