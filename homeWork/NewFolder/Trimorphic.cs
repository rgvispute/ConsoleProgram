using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.NewFolder
{
    internal class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int cube = n * n * n;
            int a = 0;int b = 0;
            Console.WriteLine("Cube " + cube);
            while(n>0)
            {
                 a = n % 10;
                 b = cube % 10;
                n = n / 10;
                cube = cube / 10;
            }
            if (a == b)
                Console.WriteLine("Tri");
            else
                Console.WriteLine("not");
        }
    }
}
          