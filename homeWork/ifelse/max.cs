using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum number between 3 number");
            Console.WriteLine("Enter three number");
            int a = Convert.ToInt32( Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a>b || a>c)
                Console.WriteLine(a + " is maximum");
            else if (b>a && b>c)
                Console.WriteLine(b+ " is maximum");
            else
                Console.WriteLine(c + " is maximum");



        }
    }
}
