using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int sum = 0;

            int n = Convert.ToInt32(Console.ReadLine());
            int x = n;
            while (n > 0)
            {
                int a = n % 10;
                sum = (sum * 10) + a;
                n = n / 10;
            }
            if (x == sum)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");






        }
    }
}
   /* class Student

    {

        string studentname;
        int rollno;
        string Teachername;

        public string Studentname { get => studentname; set => studentname = value; }
        public int Rollno { get => rollno; set => rollno = value; }
        public string Teachername { get => Teachername; set => Teachername = value; }
    }

    
    
        
    
    class test
    {
        static void Main(string[] args)
        {
             Student r = new Student();
            r.Studentname = "gaurav";
            r.Rollno = 30;
            r.Teachername = "radha";
        }
    }

    class Pen
    {
        string name;
        string brand;
        int price;
        Refill r = new Refill();

        public string Name { get => Name; set => Name = value; }
        public string Brand  { get => Brand; set => Brand = value; }
        public int Price { get =>Price; set => Price = value; }
        internal Refill R { get => r; set => r = value; }
    }

    class Refill
    {
        int length;
        string material;

        public int Length { get => length; set => length = value; }
        public string Material { get => material; set => material = value; }
    }

    class Pentest
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.Brand = "cello";
            p.Name = "pen";
            p.R.Length = 7;
            p.R.Material = "steel";
        }
    }
}*/







