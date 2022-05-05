using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPSHW
{
    internal class Order
    {
        int orderid;
        string orderdate;
        Customer cust = new Customer();
        Item item = new Item();

        public Order(int orderid, string orderdate, Customer cust, Item item)
        {
            this.orderid = orderid;
            this.orderdate = orderdate;
            this.cust = cust;
            this.item = item;
        }
        public Order(int orderid, string orderdate)
        {
            this.orderid = orderid;
            this.orderdate = orderdate;
        }

        public Order()
        {
            Console.WriteLine("order");

        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        public Customer Cust { get => cust; set => cust = value; }
        public Item Item { get => item; set => item = value; }
    }

    class Customer
    {
        int custid;
        public string custname;
        Address address = new Address();

        public Customer(int custid, string custname, Address address)
        {
            this.custid = custid;
            this.custname = custname;
            this.address = address;
        }
        public Customer()
        {
            Console.WriteLine("customer");
            
        }

        public int Custid
        {
            set { custid = value; }
            get { return custid; }
        }
        public string Custname
        {
            set { custname = value; }
            get { return custname; }
        }
        public Address Address
        {
            set { address = value; }
            get { return address; }
        }

    }
    class Address
    {
        public Address()
        {
            Console.WriteLine("ad");
        }
        public string Addr1
        {
            set;
            get;
        }
        public string City
        {
            set;
            get;
        }
        public int Pincode
        {
            set;
            get;
        }

    }

    class Item
    {
        int itemid;
        string itemname;
        int price;

        public Item(int itemid, string itemname, int price)
        {
            this.itemid = itemid;
            this.itemname = itemname;
            this.price = price;
        }

        public Item()
        {
            Console.WriteLine("item");

        }

        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public int Price { get => price; set => price = value; }
    }

    class Ordertest
    {
        static void Main(string[] args)
        {
            Order a = new Order(23,"23/04/97");
            a.Orderid = 23;
            a.Orderdate = "april";
            a.Cust.Custid = 45;
            a.Cust.custname = "ruchita";
            a.Item.Itemid = 78;
            a.Item.Itemname = "Dress";
            a.Item.Price = 450;
            a.Cust.Address.City = "Khamgaon";
            a.Cust.Address.Addr1 = "rallis plot";
            a.Cust.Address.Pincode = 444303;
            Console.Write($"orderid {a.Orderid} orderdate {a.Orderdate} custid {a.Cust.Custid} custname {a.Cust.custname} item {a.Item.Itemid} itemname {a.Item.Itemname} price {a.Item.Price} city {a.Cust.Address.City} add1 {a.Cust.Address.Addr1} pincode {a.Cust.Address.Pincode}");
            




            
        }
    }
}


