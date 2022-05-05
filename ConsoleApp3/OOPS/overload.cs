using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class overload
    {
        public void add(int a, int b)
        {
            Console.WriteLine("sum " + (a + b));
        }

        public void add(float a, float b)
        {
            Console.WriteLine("sum " + (a + b));
        }

        public void add(int a, float b)
        {
            Console.WriteLine("sum " + (a + b));
        }

        public void add(float a, int b)
        {
            Console.WriteLine("sum " + (a + b));
        }
    }

        class Load
        {
            static void Main(string[] args)
            {
                overload o = new overload();
                o.add(2,3);
                o.add(3, 3.5f);
            }
        }
        
    
}
