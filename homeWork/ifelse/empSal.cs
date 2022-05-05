using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class empSal
    {
        static void Main(string[] args)
        {
            //5875 
            Console.WriteLine("Salary Calculation");
            Console.WriteLine("Enter the Basic Salary of Employee");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 10000)
                Console.WriteLine("Gross Salary : " + (a + (a * .2) + (a * .8)));
            else if (a <= 20000 && a > 10000)
                Console.WriteLine("Gross Salary : " + (a + (a * .25) + (a * 9)));
            else
                Console.WriteLine("Gross Salary : " + (a + (a * .30) + (a * .95)));
           

        }
    }
}
