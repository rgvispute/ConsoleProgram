using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Array
{
    internal class Arrayeven
    {
        static void Main(string[] args)
        {
            int[] a =new int [5] ;
            int even = 0;
            int odd = 0;
            Console.WriteLine("Enter the elements of array");

            for (int i = 1; i < a.Length; i++)
            {

                a[i] = Convert.ToInt32(Console.ReadLine());



                if (a[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine("even "+even);
            Console.WriteLine("odd "+odd);
        }
    }
    class Mearge
    {
        static void Main(string[] args)
        {


            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 5, 6, 7, 8, 9, };
            int[] c = new int[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];

            }
            for (int i = 0; i < b.Length; i++)
            {
                c[i + a.Length] = b[i];
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }

    class Add
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 5, 6, 7, 8, 9, };
            int[] c = new int[5];
            for(int i=0;i<a.Length;i++)
            {
                c[i] = a[i] + b[i];
                Console.WriteLine(c[i]);
            }
        }
    }


    class Alternate
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 5, 6, 7, 8, 9, };
            int[] c = new int[a.Length + b.Length];

            for(int i=0;i<a.Length;i++)
            {
                c[i] = a[i];
                c[i] = b[i + a.Length];
                Console.WriteLine(c[i]);
                
            }


        }
    }
}
