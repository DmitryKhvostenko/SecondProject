using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    internal class Transport
    {
        string name;
        string category;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public Transport(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }
}
