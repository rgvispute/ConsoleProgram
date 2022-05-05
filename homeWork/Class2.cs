using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            
            int a = 5876; 
            int sum = 0;
                sum = a % 100;
                a = a/ 100;
                sum = sum + a;

            Console.WriteLine("sum of number is " +sum);

        }
    }
}
