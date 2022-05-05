using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class div
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Num is Divisible by 5 and 11 or not");
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console   .ReadLine()) ;
            if(num%5 == 0 && num%11 == 0 )
                Console.WriteLine("Number is divisible by both");
            else
                Console.WriteLine("Number is not divisible by both");
        }
    }
}
