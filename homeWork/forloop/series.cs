using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.forloop
{
    internal class series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
           // int sq;
            for(int i=1;i<=n;i++)
            {
                i = (n * n) + 1;
            }
            Console.WriteLine('i');

                
        }
    }
}
