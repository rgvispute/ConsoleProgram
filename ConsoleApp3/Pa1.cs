using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Pa1
    {
        static void Main(string[] args)
        {
            for (int i = 6; i >= 1; i--)
            {
                
                    for (int s = 1; s <=6-i; s++)
                        Console.Write(" ");
                
                

                    for (int j = 1; j <= i; j++)
                        Console.Write(j);
                
                Console.WriteLine("");

            }
        }
    }
}
     

        
    

