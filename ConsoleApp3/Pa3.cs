using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Pa3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for star");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1;i<=n;i++)
            {
               for (int s = 1; s <=n-i; s++)

                    Console.Write(" ");
                

               for(int j=1;j<=2*i-1;j++)
                    Console.Write("*");
                   
                    
                       

                
                Console.WriteLine(" ");
            }
        }
    }

    }              