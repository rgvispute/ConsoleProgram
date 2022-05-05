using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Stringcode
{
    internal class Basicstring
    {
        static void Main(string[] args)
        {
            string s = new string("ruchita");
            Console.WriteLine("input: "+s);
            //for converting uppercase
            string s1 = s.ToUpper();
            Console.WriteLine("Upper: "+s1);
            //for converting lower
            string s2 = s1.ToLower();
            Console.WriteLine("Lower: "+s2);
            //print single alphabet
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.WriteLine("///////////////////////");
            //print in reverse order
            for(int i=s1.Length-1;i>=0 ; i--)
            {
                Console.WriteLine(s1[i]);
            }

           // Console.WriteLine("Replace");
            string dd = s.Replace('r', 't');
            Console.WriteLine("Replace string: "+dd);

            string rr = s.Remove(5);
            Console.WriteLine(rr);


            string sub = s.Substring(2);
            string s44 = s.Substring(2,4);
            Console.WriteLine(sub);
            Console.WriteLine(s44);
            
            

        }
    }

    class Palindrome1
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Palindrome program");
            string r =  "nitin";
            
            string rev = "";
            for(int i=r.Length-1;i>=0;i--)
            {
                rev = rev + r[i];
            }
            if(r==rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");


        }
    }

    class rev
    {
        static void Main(string[] args)
        {
            string s5 = "I am very happy";
            //Console.WriteLine(s5);
            string[] a = s5.Split(" ");
             foreach (string word in a)
            {


                for (int j = word.Length - 1; j >= 0; j--)
                {
                    Console.Write(word[j]);
                }
                Console.Write(" ");
            }
        }
    }
}
