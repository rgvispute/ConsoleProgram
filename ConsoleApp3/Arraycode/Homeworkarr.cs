using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Arraycode
{
    internal class Homeworkarr
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int c = 0;
            Console.WriteLine("Enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    c++;
            }
            Console.WriteLine("Odd numbers " + c);

        }
    }

    class Min
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            int min = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (min < a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Min number " + min);


        }
    }

    class Present
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            Console.WriteLine("Enter number");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter number to check");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if (n == a[i])
                {

                    Console.WriteLine("yes present");
                }



                else

                    Console.WriteLine("not present");
            }
        }
    }

    class Long
    {
        static void Main(string[] args)
        {
            string line = "Find longest word from the string";
            string[] words = line.Split("");
            string word = "";
            int ctr = 0;
            //for(int i=0;i<s.Length;i++)
            foreach (string s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
        }


    }

    class Vowels
    {
        static void Main(string[] args)
        {
            string s1 = "Count number of vowels in the string";
            int c = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == 'a' || s1[i] == 'e' || s1[i] == 'i' || s1[i] == 'o' || s1[i] == 'u' || s1[i] == 'A' || s1[i] == 'E' || s1[i] == 'I' || s1[i] == 'O' || s1[i] == 'U')
                    c++;

            }
            Console.WriteLine("number of vowels " + c);

        }
    }

    class Average
    {
        static void Main(string[] args)
        {
            string s2 = "Find the average 78 of digit which 87 are pres67ent into string";
            int avg = 0;
            int sum = 0;
            int c = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                if (s2[i] >= '0' && s2[i] <= '9')
                {
                    //Console.WriteLine(s2[i]);
                    int x = (int)(Char.GetNumericValue(s2[i]));

                    sum = x + sum;
                    c++;
                }
            }
            Console.WriteLine(sum+"    "+c);
                avg = sum / c;
               Console.WriteLine(avg);


            
        }
    }

    class Occurrences
    {
        static void Main(string[] args)
        {
            string s3 = "Find occurrences of each char  element from the  char array";
        }

    }
}

            
                

                

            
        
    

