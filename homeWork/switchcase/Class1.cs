using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate area and perimeter");
           // Console.WriteLine("press-1");
             Console.WriteLine("press-1 To find area of circle \n press-2 To find area of square \n press-3 To find area of right angle triangle \n press-4 To find area of rectangle \n press-5 To find area of Circumference of a circle \n press-6 To find perimeter of square");
            // Console.WriteLine("press-2 To find area of square");
            // Console.WriteLine("press-3 To find area of right angle triangle");
            // Console.WriteLine("press-4 To find area of rectangle");
            //Console.WriteLine("press-5 To find area of Circumference of a circle");
            //Console.WriteLine("press-6 To find perimeter of square");
            //Console.WriteLine("Enter number between 1-6");
            int choice = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter the radius");
            //int radius = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("press-1 To find area of circle");
            //   int side = Convert.ToInt32(Console.ReadLine());
            // int length = Convert.ToInt32(Console.ReadLine());
            //int breath = Convert.ToInt32(Console.ReadLine());
            //nt height = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the radius");
                    int r1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("area of circle = " + (3.14 * r1 * r1));
                    break;

                case 2:
                    Console.WriteLine("Enter Side of Square");
                    int s2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("area of square = " + (s2 * s2));
                    break;

                case 3:
                    Console.WriteLine("Enter the Side of Triangle");
                    int s3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Height of Triangle");
                    int h3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("area of right angle triangle = " + (0.5 * s3 * h3));
                    break;

                case 4:
                    Console.WriteLine("Enter the Lenght of Rectangle");
                    int l4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Breath of Rectangle");
                    int b4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("area of rectangle = " + (l4 * b4));
                    break;

                case 5:
                    Console.WriteLine("Enter the radius of Circle");
                    int r5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Circumference of circle = " + (2 * 3.14 * r5));
                    break;


                case 6:
                    Console.WriteLine("Enter the side of Square");
                    int s6 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("perimeter of square = " + (4 * s6));
                    break;

                default:
                    Console.WriteLine("You have not enter the value between 1 to 6. Request you to enter the value between 1 to 6");
                    break;
            }




        }
    }
}
