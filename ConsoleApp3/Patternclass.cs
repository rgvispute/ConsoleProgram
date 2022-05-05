using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Patternclass
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                {
                    for (int s = 1; s <= 5 - i; s++)
                        Console.Write(" ");
                }
                {

                    for (int j = 1; j <= i; j++)
                        Console.Write(j);
                }
                Console.WriteLine("");

            }
        }
    }
}
     
