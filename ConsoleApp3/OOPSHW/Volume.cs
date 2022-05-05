using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPSHW
{
    internal class Volume
    {
        public void volume(double r)
        {
            Console.WriteLine("Volume of sphere = "+(4/3*22/7*r));
        }
        public void volume(double h,double r)
        {
            Console.WriteLine("Volume of cylinder = "+(22/7*r*h));
        }
        public void volume(double l,double b,double h)
        {
            Console.WriteLine("Volume of Cuboid = "+(l*b*h));
        }

    }

    class Volumetest
    {
        static void Main(string[] args)
        {
            Volume v = new Volume();
            v.volume(3.4);
        }
    }
}
