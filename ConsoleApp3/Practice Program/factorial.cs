using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Practice_Program
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i=1; i<=a; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial = " +fact);
        }
    }
}
