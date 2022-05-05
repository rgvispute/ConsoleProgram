using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Neon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sq = n * n;

            int sum = 0;

            while(sq>0)
            {
                int d = sq % 10;
                sum = sum + d;
                sq= sq / 10;
            }
            if (sum == n)
            {
                Console.WriteLine("Neon number");
            }
            else
               Console.WriteLine("Not Neon");
        }
    }
}
