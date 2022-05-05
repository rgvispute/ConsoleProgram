using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class xo
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int b = 0;

            while(n>0)
            {
                int a = n % 10;
                b++;
                if (a % 2 != 0)
                    c++;
                n = n / 10;

            }
            if(c==b)
                Console.WriteLine("Happy number");
            else
                Console.WriteLine("Not happy");

        }
    }
}
