using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.NewFolder
{
    internal class Redblue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 to 100");
            for(int i =1;i<=100;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + " Red Blue");
                else if (i % 3 == 0)
                    Console.WriteLine(i + " Red");
                else if (i % 5 == 0)
                    Console.WriteLine(i+ " Blue");
                else
                    Console.WriteLine(i + " ");
            }
        }
    }
}
