using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Fibo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for tearms");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            for (int i = 0; i <= n; i++)
            {
                c = a + b;
                Console.Write(a+" " ,b+" ", +c);
                a = b;
                b = c;

            }
           // Console.WriteLine("{0}{1}{2}",a,b,c);
        }

    }
}