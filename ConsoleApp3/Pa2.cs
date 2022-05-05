using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Pa2
    {
        static void Main(string[] args)
        {
            for (int i = 6; i >= 1; i--)
            {

                for (int s = 1; s < i; s++)
                {
                    Console.Write(" ");
                }




                for (int j = i; j <= 6; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");

            }
        }
    }
}
     

        
    

