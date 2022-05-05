using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork.forloop
{
    internal class Square
    {
        static void Main(string[] args)
        {
            int sq;
            Console.WriteLine("Print square 1 to 20");
            for(int i = 1; i<=20; i++)
            {
                sq = i * i;
                Console.WriteLine( +sq );
            }
        }
    }
}
