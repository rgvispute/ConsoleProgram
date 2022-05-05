using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{

    /* 1
     * 22
     * 333
     * 444
     * 55555*/
    internal class P1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(i);

                }
                Console.WriteLine("");
            }



        }
    }

    /* 55555
     * 4444
     * 333
     * 22
     * 1*/
    class P2
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j =1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }

           
        }
    }


    /*
     * 
     * 
     * 
     *      1
     *      12
     *      123
     *      1234
     *      12345
     *      */

    class P3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {

                    Console.Write(j);
                }

                Console.WriteLine(" ");
            }
        }
    }



    class P4
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);

                Console.WriteLine(" ");
            }

           
        }
    }
}