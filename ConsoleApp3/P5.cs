using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{


    /* internal class P5
     {
         static void Main(string[] args)
         {
             for (char i = 'A'; i <= 'E'; i++)
             {
                 {
                     for (char j = 'A'; j <= i; j++)
                         Console.Write(j);
                 }
                 Console.WriteLine(" ");
             }
         }
     }
 }*/
    internal class P5
    {
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                {
                    for (char j = 'A'; j <= i; j++)
                        Console.Write(j);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
