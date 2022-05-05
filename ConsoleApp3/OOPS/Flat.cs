using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Flat
    {
        string bname;
        int fno;
        owner ob = new owner();
        parking p = new parking();

        public string Bname { get => bname; set => bname = value; }
        public int Fno { get => fno; set => fno = value; }
        internal owner Ob { get => ob; set => ob = value; }
        internal parking P { get => p; set => p = value; }
    }
    class parking
    {
        string gardname;
        int carno;

        public string Gardname { get => gardname; set => gardname = value; }
        public int Carno { get => carno; set => carno = value; }
    }

    class owner
    {
        string ownername;
        int age;
        string prof;
        char gender;

        public string Ownername  { get => ownername; set => ownername = value; }
        public int Age { get => age; set => age = value; }
        public string Prof { get => prof; set => prof = value; }
        public char Gender { get => gender; set => gender = value; }
    }

    class Flattest

    {
        static void Main(string[] args)
        {

            Flat F = new Flat();
            F.Bname = "kunal";
            F.Fno = 202;
            F.Ob.Ownername = "Ruchita";
            F.Ob.Age = 34;
            F.Ob.Prof = "Engg";
            F.Ob.Gender = 'f';
            F.P.Gardname = "vishal";
            F.P.Carno = 143;
            Console.WriteLine(F.Bname);
            Console.WriteLine(F.Fno);
            Console.WriteLine(F.Ob.Ownername);
            Console.WriteLine(F.Ob.Prof);
            Console.WriteLine(F.Ob.Gender);
            Console.WriteLine(F.P.Gardname);
            Console.WriteLine(F.P.Carno);
        }
    }
}
