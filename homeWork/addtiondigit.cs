using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class addtiondigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(n>0)
            {
                int d = n % 10;
                sum = sum + d;
                n = n / 10;
            }
            Console.WriteLine("Addition of digit is "+sum);
        }
    }
}
