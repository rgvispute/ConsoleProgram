using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Over
    {

       public void m1()
        {
            Console.WriteLine("in m1 of over");

        }
        public Over()
        {
            Console.WriteLine("In over");

        }
        public virtual void book()
        {
            Console.WriteLine("reading book");

        }

        public virtual void study()
        {
            Console.WriteLine("book");
        }
    }

          class child :Over

           
        {

        public  new void m1()
        {
            Console.WriteLine("in m1 of child");
        }
            public override void study()
            {
                Console.WriteLine("In child");
            }
        }

        class child1: child
        {
            public void learing()
            {
                Console.WriteLine("learing online");
            }

        }

    

    class test
    {
        static void Main(string[] args)
        {
            Over O = new child();
            O.study();
            O.book();
            O.m1();
            child1 c1 = new child1();
            c1.learing();
            child c = new child1();

        }
    }

}
