using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.forloop
{
    internal class odd
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("odd number between 521 to 229");
             int i = 521;
            while( i >= 229)
            {
                if (i % 2 != 0)
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
    

