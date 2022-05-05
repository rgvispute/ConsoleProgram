using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.forloop
{
    internal class Fibbo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            for (int i = 1; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;

            }
           Console.WriteLine(c);

        }
    }
}
