using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class charCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Character Check");
            Console.WriteLine("Enter the value to be check");
            char x = Convert.ToChar(Console.ReadLine());
            if (x == '0' || x == '1' || x == '2' || x == '3' || x == '4' || x == '5' || x == '6' || x == '7' || x == '8' || x == '9')
                Console.WriteLine("Enter value is number");
            else if
            (x == '!' || x == '@' || x == '#' || x == '$' || x == '%' || x == '^' || x == '&' || x == '*' || x == '(' || x == ')' || x == '_' || x == '<' || x == '>' || x == '?')
                    Console.WriteLine("Enter value is Special Character");
            else
                Console.WriteLine("Enter value is Alphabate");
        }
    }
}
