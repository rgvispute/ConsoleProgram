using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Account
    {
        int deposit;
        int withdraw;


        public void Accecpt()
        {
            Console.WriteLine("Enter the deposit and withdraw");
             deposit = Convert.ToInt32(Console.ReadLine());
            withdraw = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
        Console.WriteLine("Deposit and withdraw ");
        }

        class Accounttest
        {
            static void Main(string[] args)
            {
                Account A = new Account();
                A.Accecpt();
                A.Display();
            }
        }

    }
}
