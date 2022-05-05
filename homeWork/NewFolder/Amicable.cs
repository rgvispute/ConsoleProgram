using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.NewFolder
{
    internal class Amicable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
             for(int i=1;i<=a;i++)
            {
                if (a % i == 0)
                    sum1 = sum1 + i;
            }
             for(int i=1;i<=b;i++)
            {
                if (b % i == 0)
                    sum2 = sum2 + i;
            }
             if(sum1==sum2)
                Console.WriteLine("Amicable number");
             else
                Console.WriteLine("not Amicable");

        }
    }
    
}
