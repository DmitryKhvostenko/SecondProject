using System;

namespace Task21
{
    public class Student
    {
        string name;
        int mark1;
        int mark2;
        double average;
        public double Average
        {
            get { return average; }
            set { average = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }    
        }
        public int Mark1
        {
            get { return mark1; }
            set { mark1 = value; }
        }
        public int Mark2
        {
            get { return mark2; }
            set { mark2 = value; }
        }
        public Student(string name,int mark1,int mark2,double average)
        {
            Name = name;
            Mark1 = mark1;
            Mark2 = mark2;
            Average = average;
        }
        public Student() { }

    }
}
