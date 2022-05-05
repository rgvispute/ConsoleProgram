using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int t = a;
            while (a > 0)
            {
                int n = a % 10;
                sum = sum + n;
                a = a / 10;

            }
            if (t % sum == 0)
            
                Console.WriteLine("Harshad number ");
            
             else
                Console.WriteLine("Not Harshad");
        }
    }
    
}
