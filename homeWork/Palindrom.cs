using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int x = n;
            while(n>0)
            {
                int d = n % 10;
                sum = sum *10 + d;
                n = n / 10;
            }
            if (sum == x)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("Not");
                

        }
    }
}
