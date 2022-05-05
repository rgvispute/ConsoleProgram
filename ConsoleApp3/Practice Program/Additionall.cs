using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Practice_Program
{
    internal class Addition
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1; i<=10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Addition is " +sum);
        }
    }
}




