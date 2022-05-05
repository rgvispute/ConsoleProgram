using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 7 == 0)
            {
                Console.WriteLine("Number is Divisible by 7");

            }
            else
            {
                Console.WriteLine("Number not Divisible by 7");
              }          
            Console.WriteLine("a={0}", a);
        }
    }
}
