using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class simCal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Select Action to be Perform");
            Console.WriteLine("For Addition Press a");
            Console.WriteLine("For Subtraction Press s");
            Console.WriteLine("For Multiplication Press m");
            Console.WriteLine("For Divison Press d");
            char x = Convert.ToChar(Console.Read());
            Console.WriteLine("Enter the First number");
            int y = Convert.ToInt32(Console.Read());
            Console.WriteLine("Enter the Second number");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x == 'a')
                Console.WriteLine("Addition of two numbers is " + (y + z));
            else if (x == 's')
                Console.WriteLine("Substraction of two numbers is " + (y - z));
            else if (x == 'm')
                Console.WriteLine("Multiplication of two numbers is " + (y * z));
            else
                Console.WriteLine("Division of two numbers is " + (y/z));
        }
    }
}
