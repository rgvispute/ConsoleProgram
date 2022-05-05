using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{

    internal class Tripatt
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 20; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }


internal class Tripattr
{
    static void Main(string[] args)
    {
        for (int r = 1; r <= 20; r--)
        {
            for (int c = 1; c <= r; c++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
    }
}
}

