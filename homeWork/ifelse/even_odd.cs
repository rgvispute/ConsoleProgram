using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class even_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numner is even or odd");
            Console.WriteLine("Enter the number ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
                Console.WriteLine(n+ " the number is even");
            else
                Console.WriteLine( n +" the number is odd");

        }
    }
}
