using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Recursion
    {
        public static int factorial(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                int ans = factorial(n - 1);
                return n * ans;
              //  Console.WriteLine(result);
            }

        }
        static void Main(string[] args)
        {
            int result = factorial(5);
        }

    }

}
