using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Pen
    {
        string penname;
        string brand;
        int price;
        string color;


        //constructure
        public Pen()
        {
            Console.WriteLine("Welcome to cello company");

        }

        public Pen(string name, string b, int p, string c)

        {
            penname = name;
            brand = b;
            price = p;
            color = c;

        }

        public void Setpenname(string name)
        {
            penname = name;
        }
        public string getpenname()
        {
            return penname;
        }
        public void Setbrand(string b)
        {
            brand = b;
        }
        public string getbrand()
        {
            return brand;

        }
        public void Setprice(int p)
        {
            price = p;
        }
        public int getprice()
        {
            return price;
        }
        public void Setcolor(string c)
        {
            color = c;
        }
        public string getcolor()
        {
            return color;

        }
    }

    class Pentest
    {
        static void Main(string[] args)


        {

            Pen p2 = new Pen("cello", "a2", 15, "black");
            Pen p1 = new Pen();
            Console.WriteLine("Enter penname,penbrand,price and color");


            string penname = Console.ReadLine();
            string brand = Console.ReadLine();
            int Price = Convert.ToInt32(Console.ReadLine());
            string color = Console.ReadLine();

            p1.Setpenname(penname);
            p1.Setbrand(brand);
            p1.Setprice(Price);
            p1.Setcolor(color);



            Console.WriteLine("penname " + p1.getpenname(), "Brand " + p1.getbrand(), "Price " + p1.getprice(), "color " + p1.getcolor());
        }
    }

}   