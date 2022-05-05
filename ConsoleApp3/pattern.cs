using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{


    internal class pattern1
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 5; i--) 
            {
                for (int j = 5; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
        }
    }
}

/*internal class pattern2
{
    static void Main(string[] args)
    {
        int i = 1;
        for (int i = 1; i <= 5; i--)
        {
            for (int j = 5; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine(" ");
        }
    }
}*/


