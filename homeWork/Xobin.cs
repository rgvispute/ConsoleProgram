using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Xobin
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int x = 0, y = 0;int s=0;
            while(a>0)
            {
                 x = a % 10;
                y = a % 10;
                 
               // s = x; 
                 
               a = a / 10;

            }
            if(x<y )
                Console.WriteLine("Increasing");
            else if(x>y)
                Console.WriteLine("Decreasing");
            else
                Console.WriteLine("Bouncy");

            
        }
    }
}
