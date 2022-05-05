using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Array
{
    internal class Array2d
    {
        static void Main(string[] args)
        {
            int[,] aa = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("**"+aa.Length);
            for (int r = 0; r<aa.GetLength(0); r++)
            {
                Console.WriteLine("Enter elements of row" + r);
                for (int c = 0; c < aa.GetLength(1); c++)
                {

                    aa[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int r=0;r<aa.GetLength(0);r++)
            {
                for(int c=0;c<aa.GetLength(1);c++)
                {
                    Console.Write(aa[r,c]);
                }
            }
        }
    }

    class Max2d
    {
        static void Main(string[] args)
        {

        }
    }
}
