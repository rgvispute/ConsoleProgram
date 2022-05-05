using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Overloadarea
    {
        public void area(int a)
        {
            Console.WriteLine("Area of square "+(a*a));
        }
        public void area(int a,int b)
        {
            Console.WriteLine("Area of rectangle "+(a*b));
        }
        public void area(float a)
        {
            Console.WriteLine("Area of circle "+(3.14*a*a));
        }
    }

    class Area1
    {
        static void Main(string[] args)
        {
            Overloadarea A = new Overloadarea();
            A.area(3,7);
        }
    }
}
