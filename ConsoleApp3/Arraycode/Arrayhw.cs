using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Array
{
    internal class Arrayhw
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];

            Console.WriteLine($"Enter elements{b.Length}");
            for(int i =0;i<b.Length;i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

           // foreach(int b in a)
            {
                Console.Write("Elements in 1D array is "+b);
            }
        }
    }

    class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            double average = 0;
            int sum = 0;

            int[] a = new int[size];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            average = sum / a.Length;
            Console.WriteLine("Average of elements is "+average);
                

            
        }
    }

    class Index
    {
        static void Main(string[] args)
        {
            int[] a = new int [5];
            Console.WriteLine("Enter elements ");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
        }
    }

    class Itearating
    {
        static void Main(string[] args)
        {
            int[] mya = { 2, 3, 4, 5, 6, 7 };
            int[] a = new int[mya.Length];
            //Console.WriteLine("My array "+mya.Length);
            for (int i = 0; i < mya.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                a[i] = mya[i];
            }
            for(int i=0;i<a.Length;i++)
            { 


                Console.WriteLine("New array " + a[i]);
            }

        }
    }

    class Reverse
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.WriteLine("Array in reverse order: ");
            //Loop through the array in reverse order  
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("Array in alternet order: ");
            for(int i=arr.Length-1;i>0;i=i-2)
            {
                Console.WriteLine(arr[i]+" ");

            }
        }
    }

    class Inseart
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of arry");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
                for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
            Console.WriteLine("Enter position or index where u want");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter data u want to insert");
            int data = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Enter the data u want to inseart");
            int p = 0;
            int size = 0;
          //  int data = Convert.ToInt32(Console.ReadLine());
            if(pos==size)
            {
                arr[size] = data;
                size++;
            }
            else if(pos>=0 && pos<size)
            {
                for(int k = size; k > pos; k--)
                {
                    arr[k + 1] = arr[k];
                }
                arr[pos] = data;
            }
            else
                Console.WriteLine("Index out of range");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]+" ");
            }


        }
    }

    class Negative
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int c = 0;
            Console.WriteLine("Enter elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Negative number are ");
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] < 0)
                {
                    Console.WriteLine(a[i]);
                    c++;
                }
            }
            Console.WriteLine("Negative number in array "+c);
        }
    }

    class Evenodd
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            int[] even = new int[a.Length];
            int[] odd = new int[a.Length];

            Console.WriteLine("Enter the elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 == 0)
                    even[i] = a[i];
                Console.WriteLine(even[i]);
               
            }
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 != 0)
                    odd[i] = a[i];
                Console.WriteLine(odd[i]);
            }

        }
    }

    class Maxmin
    {
        static void Main(string[] args)
        {
            int[] a = { 23, 45, 67, -98, 65, -45, 62 };
            int max = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(max>a[i])
                {
                    max = a[i];
                }
                Console.WriteLine("Max "+max);
            }
        }
    }

    class Pair
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 6, 7, 8, 5, 7, 4 };
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a.Length;j++)
                {
                    if(a[i]+a[j]==sum)
                        Console.WriteLine($"Pair gives sum { a[i]}+{ a[j]}");
                }
            }
        }
    }


}
