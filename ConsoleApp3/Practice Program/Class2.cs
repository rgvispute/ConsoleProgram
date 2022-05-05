using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Simple Intrest Calculation System***");
            Console.WriteLine("Enter Principal");
            float P = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter No of Year");
            float N = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Rate of Inrest");
            float R = Convert.ToSingle(Console.ReadLine());
            float I = ((P * N * R) / 100);
            Console.WriteLine("Simple Inrest\t : \t" + I + "\t Per Yearmv"  );
        }
    }
}
