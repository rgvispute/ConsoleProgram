using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print number into word");
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
           // int choice = Convert.ToInt32(Console.ReadLine());

            switch(a)
            {
                case 1: Console.WriteLine(a +" one");
                    break;
                 case 2: Console.WriteLine(a + " Two");
                    break;
                case 3:Console.WriteLine(a + " Three");
                    break;
                case 4: Console.WriteLine(a + " Four");
                    break;
                case 5:  Console.WriteLine(a + " Five");
                    break;
                default: Console.WriteLine("sorry we can not convert");
                    break;
            }



        }
    }
}
