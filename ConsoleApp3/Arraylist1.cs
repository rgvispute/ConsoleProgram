using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassWork
{
    internal class Arraylist1
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("Ruchita");
            a1.Add("Gaurav");
            a1.Add("Dusane");
            a1.Add(23);
            a1.Add(20);
            a1.Add("rgvispute2@gmail.com");
            a1.Remove(20);
            a1.RemoveAt(1);
            //a1.RemoveRange();
            a1.Reverse();
            

            for(int i=0;i<a1.Count;i++)
            Console.WriteLine(a1[i]);

            for(int i=1;i<10;i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("////////////////////////////////////////");


            Hashtable h1 = new Hashtable();
            h1.Add("Ruchita",23);
            h1.Add("Gaurav", 20);
            h1.Add("Dusane", 43);

            ICollection keys = h1.Keys;

            foreach (String k in keys)
            {
                Console.WriteLine(h1[k]);
            }
            Console.ReadKey();



        }
           
    }
}
