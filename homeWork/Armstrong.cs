using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = n;
            int sum = 0;
            while(n>0)
            {
                int a = n % 10;
                sum = sum+ a * a * a;
                n = n / 10;


            }
            if(sum==x)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("Not Armstrong");
        }
    }
}
