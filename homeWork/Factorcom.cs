using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Factorcom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int min =a < b ? a : b;
            for(int i=1;i<=min;i++)
            {
                if(a%i==0 && b%i==0)
                    Console.WriteLine(i);
            }
        }
    }
    
}
