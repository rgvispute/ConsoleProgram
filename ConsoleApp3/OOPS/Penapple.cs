using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Penapple
    {


        string pname;
        string pbrand;
        string pcolor;
        int pprice;


        public string Pname
        {
            set { pname = value; }
            get { return pname; }

        }

        public string Pbrand
        {
            set { pbrand = value; }
            get { return pbrand; }
        }

        public string Pcolor
        {
            set { pcolor = value; }
            get { return pcolor; }


        }

        public int Pprice
        {
            set { pprice = value; }
            get { return pprice; }


        }
    }

    class Penwork
    {
        static void Main(string[] args)
        {


            Penapple P3 = new Penapple();
            P3.Pname = "renold";
            P3.Pbrand = "ball";
            P3.Pcolor = "black";
            P3.Pprice = 30;


            Console.WriteLine("Pen name " + P3.Pname);
            Console.WriteLine("Pen name " + P3.Pbrand);
            Console.WriteLine("Pen name " + P3.Pcolor);
            Console.WriteLine("Pen name " + P3.Pprice);

        }
    }


    class Employee
    {
        string ename;
        int eid;
        int salary;

        public string Ename
        {
            set { ename = value; }
            get { return ename; }
        }

        public int Eid
        {
            set { eid = value; }
            get { return eid; }
        }
        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }
    }

    class Employeetest
    {
        static void Main(string[] args)
        {
            Employee E = new Employee();
            Console.WriteLine("Enter Employee name,id and salary");
            string Ename = Console.ReadLine();
            int Eid = Convert.ToInt32(Console.ReadLine());
            int Salary = Convert.ToInt32(Console.ReadLine());
            // E.Ename("ruchita");
            // E.Eid;
             //E.Salary;
           // Console.WriteLine("name " +name,"Eid "+E.Eid,"Salary"+E,Salary);
        }
    }
}    









