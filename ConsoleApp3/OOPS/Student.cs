using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Student
    {
        string stdname;
        int age;
        float percentage;

        public string Stdname
        {
            set { stdname = value; }
            get { return stdname; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public float Percentage
        {
            set { percentage = value; }
            get { return percentage; }
        }
    }

    class  Std
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Stdname = "ruchita";
            s.Age = 23;
            s.Percentage = 78.73f;
        }
    }
}
