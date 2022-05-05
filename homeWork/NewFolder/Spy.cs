using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.NewFolder
{
    internal class Spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int mul = 1;
            while (n > 0)
            {
                int a = n % 10;
                sum = sum + a;
                mul = mul * a;
                n = n % 10;
                 
            }
            if (sum == mul)
                
                    Console.WriteLine("spy number");
                
                else
                    Console.WriteLine("Not spy number");
            
        }
    }
    
}
