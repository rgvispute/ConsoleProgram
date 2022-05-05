using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Movie
    {
        string mname;
        string Mdirector;
        string Mproducer;
        string Factor;
        string Mactor;

        //Constructor
        public Movie()
        {
            Console.WriteLine("In Movie");
        }

        public void Setmname(string name)
        {
            mname = name;
        }
        public string getmname()
        {
            return mname;
        }
        public void SetMdirector(string d)
        {
            Mdirector = d;
        }
        public string getMdirector()
        {
            return Mdirector;

        }
        public void SetMproducer(string p)
        {
            Mproducer = p;
        }
        public string getMproducer()
        {
            return Mproducer;
        }

        public void SetFactor(string f)
        {
            Factor = f;
        }
        public string getFactor()
        {
            return Factor;
        }
        public void SetMactor(string m)
        {
            Mactor = m;
        }
        public string getMactor()
        {
            return Mactor;

        }
    }
    class Movietest
    {
        static void Main(string[] args)
        {
            Movie M1 = new Movie();
            M1.Setmname("rrr");
            M1.SetMdirector("hg");
            M1.SetMproducer("mn");
            M1.SetFactor("hg");
            M1.SetMactor("jj");

            Console.WriteLine("Movie name " +M1.getmname());
            Console.WriteLine(M1.getMdirector());
            Console.WriteLine(M1.getMproducer());
            Console.WriteLine(M1.getMactor());
            Console.WriteLine(M1.getFactor());






            Console.WriteLine("Enter the Name of Movie,Director,Producer,Female and male actor");
            Movie M2 = new Movie();
            string mname = Console.ReadLine();
            string Mdirector = Console.ReadLine();
            string Mpreoducer = Console.ReadLine();
            string Mact = Console.ReadLine();
            string Fact = Console.ReadLine();

            M2.Setmname(mname);
            M2.SetMdirector(Mdirector);
            M2.SetMproducer(Mpreoducer);
            M2.SetMactor(Mact);
            M2.SetFactor(Fact);

            string mname1 = M2.getmname();
            string Mdirector1 = M2.getMdirector();
            string Mproducer1 = M2.getMproducer();
            string Mactor1 = M2.getMactor();
            string Factor1 = M2.getFactor();



            Console.WriteLine("Movie name"+M2.getmname());


            













        }
    }
}

