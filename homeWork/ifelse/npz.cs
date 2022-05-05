using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class npz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n < 0)
                Console.WriteLine("The number is negtive");
            else if (n == 0)
                Console.WriteLine("The number is Zero");
            else
                Console.WriteLine("The Number is Positive");

        }
    }
}
