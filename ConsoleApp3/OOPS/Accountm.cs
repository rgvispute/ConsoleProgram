using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Accountm
    {
        long accountno;
        string custname;


        public Accountm()
        {
            Console.WriteLine("I am in default constructure");
        }

        public void Setaccountno(long no)
        {
            accountno = no;
        }

        public long getaccountno()
        {
            return accountno;
        }

        public void Setcustname(string name)
        {
            custname = name;
        }

        public string getcustname()
        {
            return custname;
        }
    }
        class Acctest
        {
            
            static void Main(string[] args)
            {


                Accountm M = new Accountm();
                  
                M.Setaccountno (347865467);
                M.Setcustname("Ruchita");


                Console.WriteLine(M.getaccountno());
                Console.WriteLine(M.getcustname());
                    
                    
                    // Console.WriteLine("Enter account number and customer name ");
               //long accountno = Console.ReadLine();
                //string custname = Console.ReadLine();

            }
           
        }


}       