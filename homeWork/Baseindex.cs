using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Baseindex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base and index");
            int b = Convert.ToInt32(Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for(int i=1;i<=index;i++)
            {
                result = result * b;
            }
            Console.WriteLine("Result= "+result);
        }
    }
}
