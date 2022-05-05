// See https://aka.ms/new-console-template for more information

using System;
namespace Day_3
{
    class leap_year
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find Leap Year");
            Console.WriteLine("Enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            if(y%4==0)
                Console.WriteLine("This is Leap Year");
            else
                Console.WriteLine("This is not Leap Year");
        }



    }
}
