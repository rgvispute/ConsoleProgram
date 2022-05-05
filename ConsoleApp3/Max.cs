using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>b  &&  a>b)
            
            Console.WriteLine("a is greater");

             else if(b>a && b>c)
            Console.WriteLine("b is grater");
                else
              Console.WriteLine("c is greater");
            
        }
    }
}
