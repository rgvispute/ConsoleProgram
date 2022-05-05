using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPSHW
{
    internal class Pen
    {
        Refill r = new Refill();
        int caplength;
        string brand;
         public Pen()
        {
            Console.WriteLine("pen");
        }

        public Pen(Refill r, int caplength, string brand)
        {
            this.r = r;
            this.caplength = caplength;
            this.brand = brand;
        }

        public Pen(int caplenghth,string brand)
        {
            this.caplength = caplength;
            this.brand = brand;
        }

        public Refill R { get => r; set => r = value; }
        public int Caplength { get => caplength; set => caplength = value; }
        public string Brand { get => brand; set => brand = value; }
    }
    class Refill
    {
        string inkcolour;
        int length;
        string nib;
        public Refill()
        {
            Console.WriteLine(" refill");
        }

        public Refill(string inkcolour, int length, string nib)
        {
            this.inkcolour = inkcolour;
            this.length = length;
            this.nib = nib;
        }

        public string Inkcolour { get => inkcolour; set => inkcolour = value; }
        public int Length { get => length; set => length = value; }
        public string Nib { get => nib; set => nib = value; }
    }
    class Nib
    {
        string materialtype;
        int width;
        public Nib()
        {
            Console.WriteLine("Nib");

        }

        public Nib(string materialtype, int width)
        {
            this.Materialtype = materialtype;
            this.Width = width;
        }

        public string Materialtype { get => materialtype; set => materialtype = value; }
        public int Width { get => width; set => width = value; }
    }


    class Pentest1
    {
        static void Main(string[] args)
        {
            Pen P = new Pen(12,"cello");
            Nib N = new Nib();
            P.Brand = "cello";
            P.Caplength = 12;
            P.R.Inkcolour = "Red";
            P.R.Length = 8;
            P.R.Nib = "Tip";
            N.Materialtype = "Steel";
            N.Width = 3;

            Console.WriteLine($"brand {P.Brand} cap  {P.Caplength} ink {P.R.Inkcolour} len {P.R.Length} nib {P.R.Nib} type {N.Materialtype} w {N.Width}");
            


        }
    }


}
