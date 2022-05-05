using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Country
    {
        string countryname;
        int nostate;
        int nolang;
        string capital;

        public string Countryname
        {
            set { countryname = value; }
            get { return countryname; }
        }
        public int Nostate
        {
            set { nostate = value; }
            get { return nostate; }

        }
        public int Nolang
        {
            set { nolang = value; }
            get { return nolang; }

        }
        public string Capital
        {
            set { capital = value; }
            get { return capital; }
        }
    }

        class Countest
        {
            static void Main(string[] args)
            {
                Country c = new Country();
                c.Countryname ="India";
                c.Nostate = 28;
                c.Nolang = 6;
                c.Capital = "Delhi";
                Console.WriteLine("countryname "+c.Countryname);
                 Console.WriteLine(c.Nostate);
                Console.WriteLine(c.Nolang);
                Console.WriteLine(c.Capital) ;
                
            }

        }
    
} 

