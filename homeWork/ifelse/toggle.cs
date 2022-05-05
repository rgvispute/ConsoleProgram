using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class toggle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("toggle case");
            Console.WriteLine("Enter Alphabet");
            char ch = Convert.ToChar(Console.Read());
            if (ch >= 65 && ch <= 90)
            {
                ch = (char)(ch + 32);
                Console.WriteLine("Toggel Alphabate " + ch);
            }
            else if (ch >= 97 && ch <= 122)
            {
                ch = (char)(ch - 32);
                Console.WriteLine("Toggel Alphabate " + ch);
            }
            else
                Console.WriteLine("Enter value is not an Alphabet");
        }
    }
}
