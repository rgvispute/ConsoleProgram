using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Stringcode
{
    /*internal class Present
    {
        static void Main(string[] args)
        {
            string s = "ruchita";
            string s1 = "ruchi";
            bool isfound = true;
            foreach(int i=0;i>s.Length;i++)
            {

            }

        }
    }*/

    class fibo
    {
        static void Main(string[] args)
        {
            int a1 = 0;
            int a2 = 1;
            int sum = 0;
            Console.WriteLine("Enter terms of series");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n-2; i++)
            {
                
                a1 = a2;
                a2 = sum;
                sum = a1 + a2;
            }
            Console.WriteLine(sum);


        }
    }
}
