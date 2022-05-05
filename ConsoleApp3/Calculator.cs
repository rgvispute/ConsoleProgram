using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Calculator
    {
        public void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Addition " + sum);
        }

         public float si(int p, float r, int n)
         {
            float sim = p * n * r;
             return sim;
         }

          public bool leap(int y)
          {

             if (y % 4 == 0)
              return true;
             else
            return false;
          }


          static void Main(string[] args)
          {
              Calculator c = new Calculator();
             c.Add(34, 4);
              float simple = c.si(30, 40.9f, 2);
               Console.WriteLine($"Simple interest {simple}");
            bool year = c.leap(2014);
            Console.WriteLine($"Year {year}");


          }






    }
}
