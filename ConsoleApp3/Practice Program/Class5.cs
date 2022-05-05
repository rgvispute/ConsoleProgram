using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class5
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n***Perimeter and Area of Square***");
            Console.WriteLine("Enter Side of Square");
            float s = Convert.ToSingle(Console.ReadLine());
            float p = s * 4;
            float a = s * s;
            Console.WriteLine("Perimeter of Square\t : \t" + p + "\nArea of Square\t : \t" + a);
        }
    }
}
