using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class denomination
    {
        static void Main(string[] args)
        {
            Console.WriteLine("denomination");
            Console.WriteLine("Enter the amt");
            int amt = Convert.ToInt32(Console.ReadLine());

            int n2000 = amt / 2000;
            amt = amt % 2000;

            int n500 = amt / 500;
            amt = amt % 500;

            int n200 = amt / 200;
            amt = amt % 200;

            int n100 = amt / 100;
            amt = amt % 100;

            int n50 = amt / 50;
            amt = amt % 50;

            int n20 = amt / 20;
            amt = amt % 20;


            int n10 = amt / 10;
            amt = amt % 10;

            int n5 = amt / 5;
            amt = amt % 5;

            int n2 = amt / 2;
            amt = amt % 2;


            int n1 = amt / 1;
            amt = amt % 1;

            Console.WriteLine("notes of 2000= " + n2000);
            Console.WriteLine("notes of 500= "  +n500);
            Console.WriteLine("notes of 200= "  +n200);
            Console.WriteLine("notes of 100= "  +n100);
            Console.WriteLine("notes of 50= " +n50);
            Console.WriteLine("notes of 20= "  +n20);
            Console.WriteLine("notes of 10= " +n10);
            Console.WriteLine("notes of 5= " + n5);
            Console.WriteLine("notes of 2= " + n2);
            Console.WriteLine("notes of 1= "  +amt);
           
        }
    }
}
