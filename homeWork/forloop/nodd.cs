using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.forloop
{
    internal class nodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum of all odd number between 1 to n");
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for(int i=1;i<=n;i=i+2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
