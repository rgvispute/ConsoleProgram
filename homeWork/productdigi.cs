using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class productdigi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            while(n>0)
            {
                int d = n % 10;
                p = p * d;
                n = n / 10;
            }
            Console.WriteLine("Product of digits is " +p);
        }
    }
}
