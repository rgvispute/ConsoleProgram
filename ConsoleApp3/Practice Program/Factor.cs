using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Practice_Program
{
    internal class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
         
            for (int i = 1; i <= num; i++)

            {
                if(num%i==0)
                    Console.WriteLine("factor = " + i);
            }
            
        }
    }
    }

