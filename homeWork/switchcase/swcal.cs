using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class swcal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("simple calculator");
            Console.WriteLine("Enter two number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("press 1-add 2-sub 3-mul 4-div");
            Console.WriteLine("Enter your choice");
           
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:Console.WriteLine("Result of add " + (a + b));
                    break;

                case 2: Console.WriteLine("Result of sub " + (a - b));
                    break;

                case 3:Console.WriteLine("Result of mul " + (a * b));
                    break;

                case 4: Console.WriteLine("Result of div " + (a / b));
                    break;

                default:Console.WriteLine("wrong choice");
                    break;

            }



        }
    }
}
