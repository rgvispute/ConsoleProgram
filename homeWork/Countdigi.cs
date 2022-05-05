using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Countdigi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for digit counting and reverse order");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            while(n>0)
            {
                c++;
                int t = n % 10;
                Console.Write(t);
                n = n / 10;
                 
            }
            Console.WriteLine(c+ " Digits");
        }
    }
}
