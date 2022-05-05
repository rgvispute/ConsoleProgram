using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class leap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int y = Convert.ToInt32(Console.ReadLine());

            String year = y % 4 == 0 ? "leap year" : "Not Leap year";
             Console.WriteLine(year);
        }
    }
}
