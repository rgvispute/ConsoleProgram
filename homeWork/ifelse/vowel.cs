using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check whether the alpabet is vowel or consonant");
            Console.WriteLine("Enter the alphabet");
            char al =Convert.ToChar(Console.Read());
           if(al=='a' || al == 'e' || al == 'i' || al == 'o' || al == 'u' || al == 'A' || al == 'E' || al == 'I' || al == 'O' || al == 'U')
                Console.WriteLine("alphabet is vowel");
            else
                Console.WriteLine("alphabet is consonant");
        }
    }
}
