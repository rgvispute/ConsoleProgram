using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***Perimeter and Area of Square***");
            Console.WriteLine("Enter Side of Square");
            float s = Convert.ToSingle(Console.ReadLine());
            float p = s*4;
            float a = s*s;
            Console.WriteLine("Perimeter of Square\t : \t" + p + "\nArea of Square\t : \t" + a);

            Console.WriteLine("\n***Avarage Marks of Students***");
            Console.WriteLine("Enter name of Subject 1");
            string? s1 = Console.ReadLine();
            Console.WriteLine("Enter Marks obtain in Subject 1");
            float m1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter name of Subject 2");
            string? s2 = Console.ReadLine();
            Console.WriteLine("Enter Marks obtain in Subject 2");
            float m2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter name of Subject 3");
            string? s3 = Console.ReadLine();
            Console.WriteLine("Enter Marks obtain in Subject 3");
            float m3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter name of Subject 4");
            string? s4 = Console.ReadLine();
            Console.WriteLine("Enter Marks obtain in Subject 4");
            float m4 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter name of Subject 5");
            string? s5 = Console.ReadLine();
            Console.WriteLine("Enter Marks obtain in Subject 5");
            float m5 = Convert.ToSingle(Console.ReadLine());
            float avg = (m1+m2+m3+m4+m5)/5;
            Console.WriteLine("Avarage of Mark Obtained \t : \t" + avg );

            Console.WriteLine("\n***20% Discount***");
            Console.WriteLine("Enter Amount need to pay by user");
            float amt1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Discount to be applied");
            float dis1 = Convert.ToSingle(Console.ReadLine());
            float amt2 = amt1 - (amt1 * (dis1/100));
            Console.WriteLine("Amount to be paid after 20 % Discount\t : \t" + amt2 );

        }
    }
}
