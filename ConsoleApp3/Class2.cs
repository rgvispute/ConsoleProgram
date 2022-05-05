using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            //x = int(input(""));
            int x=Convert.ToInt32(Console.ReadLine());

             int count1 = 0;

             int res = 1;

            int count2 = count1;

            while (count1 != x)

           res = count1 % 2;

            if (res != 0)

            count2 = count2 + 1;

            count1 = count1 + 1;

            Console.WriteLine(count2 - 1);
        }
    }

    class cp
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int gcd = 0;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int divisor = 1; divisor <= i; divisor++)
                {
                    if (n % divisor == 0 && i % divisor == 0)
                        gcd = divisor;
                }

                if (gcd == 1)
                    c++;
            }
            Console.WriteLine(c);

        }
    }
}
