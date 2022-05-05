using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Book
    {
        public string Name;
        public string Nameofauthor;
        public string Nameofpublication;
        public int numberofpage;
        public int price;


        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.Name = "Wings of Fire";
            b1.Nameofauthor = "Abdul Kalam";
            b1.Nameofpublication = "Edition";
            b1.numberofpage = 200;
            b1.price = 150;
            Console.WriteLine($"");


        }
    }

    class Booktest
    {
        static void Main(string[] args)
        {
            Book b2 = new Book();
            Console.WriteLine("Enter Name, author,Publication,page and price");
            b2.Name = Console.ReadLine();
            b2.Nameofauthor = Console.ReadLine();
            b2.Nameofpublication = Console.ReadLine();
            b2.numberofpage = Convert.ToInt32(Console.ReadLine());
            b2.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"book name{b2.Name}author{b2.Nameofauthor}publication{b2.Nameofpublication}numberofpage{b2.numberofpage}price{b2.price}");


            Book b1 = new Book();
            b1.Name = "Wings of Fire";
            b1.Nameofauthor = "Abdul Kalam";
            b1.Nameofpublication = "Edition";
            b1.numberofpage = 200;
            b1.price = 150;
            Console.WriteLine($"book name");


        }
    }
}
