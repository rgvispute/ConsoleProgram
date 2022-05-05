using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Diamond
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Star");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for(int i=n;i>=1;i--)
            {
                for(int s=1;s<n-i;s++)
                    Console.Write(" ");

                for(int j=1;j<=2*i-1;j++)
                    Console.Write("*");

                Console.WriteLine("");
            }
        }
    }
}
