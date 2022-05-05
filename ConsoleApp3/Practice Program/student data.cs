using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class student_data
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***Avarage Marks of Students***");
            Console.WriteLine("Enter Name of student");
            string? s = Console.ReadLine();
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
            float avg = (m1 + m2 + m3 + m4 + m5) / 5;
            Console.WriteLine("Avarage of Mark Obtained by " + s + " is " + avg);

        }
    }
}
