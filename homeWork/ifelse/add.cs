using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class add
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum of 1st and 3rd digit");
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n>=99 && n<=999)
                Console.WriteLine("The number is 3 digit number");
            else
                Console.WriteLine("The number is not 3 digit number");
        }

    }
}
