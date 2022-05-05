using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 2, 4, 10 };
            int diff = 0;
            int n = 0;


            for (int i = 0; i < a.Length; i++)
            {

                for (int j = i + 1; j < a.Length; j++)
                {

                    if (a[i] > a[j])
                    {

                        n = a[i];
                        a[i] = a[j];
                        a[j] = n;

                    }
                   
                }
                Console.Write(" "+a[i]);
                
            }
            Console.WriteLine(" ");

            for(int i=0; i < a.Length; i++)
            {

               diff= Math.Abs(a[i + 1] - a[i]);
                if (diff == 2)
                {
                   
                    Console.WriteLine(" " + a[i] + " " + a[i + 1]);
                }
                    

                

            }
            Console.WriteLine(" ");
            
            

        }
    }
}

