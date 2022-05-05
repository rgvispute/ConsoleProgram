using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class P7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++)
            {
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        if (i % 2 == 0)
                            Console.Write("@");
                        else
                            Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


internal class P8
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j % 2 == 0)
                        Console.Write("@");
                    else
                        Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }
}

