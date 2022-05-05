using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.NewFolder
{
    internal class Eo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 to 50 even and odd");
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(i*i);
            }    
        }
    }
}
