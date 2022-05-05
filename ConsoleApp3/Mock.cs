using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Mock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int c = 0;
            while(n>0)
            {
                int a = n % 10;

                if (a % 2 == 0)
                {
                    sum = sum + a;
                    c++;
                }
                
                   n = n / 10;


            }
            Console.WriteLine("Sum of even digit "+sum);

            Console.WriteLine("Final ans "+sum/c);
        }
    } 
}
