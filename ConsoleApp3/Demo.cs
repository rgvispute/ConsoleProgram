using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                float div = 0;
                sum = a + b;
                div = a / b;

                Console.WriteLine("Sum  :" + sum);

            }

            catch(FormatException)
            {
                Console.WriteLine("Wrong data");

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("cant enter zero");
            }
            catch(Exception)
            {
                Console.WriteLine("Error");
            }

        }
    }

    class mobile
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Enter mobile number");
                long number = Convert.ToInt64(Console.ReadLine());
                int c = 0;
                //int a = 0;
                while (number > 0)
                {
                    c++;
                    number = number / 10;
                }
                if (c == 10)
                {
                    Console.WriteLine("valid number");
                }
                else
                    throw new Invalidmobileexception();
                    

                
                

            
           
        }
    }

    class Invalidmobileexception:ApplicationException
    {
        public Invalidmobileexception()
        {
            Console.WriteLine("In exception");
        }
    }


    class Homework
    {
        static void Main(string[] args)
        {
            try
            {


            }
            catch (NullReferenceException obj)
            {
                Console.WriteLine(obj);
            }
            finally
            {
                Console.WriteLine("In Finally");
            }

            

        }
    }

    class Homework2
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                int sub = 0;
                int mul = 0;
                float div = 0;
                sum = a + b;
                Console.WriteLine("Sum: "+sum);
                sub = a - b;
                Console.WriteLine("Sub: "+sub);
                mul = a * b;
                Console.WriteLine("Mul: "+mul);
                div = a / b;
                Console.WriteLine("Div:" +div);

            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine(d);
            }
            catch(IndexOutOfRangeException b)
            {
                Console.WriteLine(b);
            }
            catch(FormatException a)
            {
                Console.WriteLine(a);
            }
            catch(Exception)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("All calculation done");
            }
        }
    }

    /*class Homework3
    {
        static void Main(string[] args)
        {
            try
            {

            }
           // catch()
            {

            }
        }
    }*/


    class Ageexception:ApplicationException
    {
        public Ageexception()
        {
            Console.WriteLine("In age exception");
        }
    }

    class Train
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the name and age");
                 int a =Convert.ToInt32(Console.ReadLine());
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 60)
                    Console.WriteLine(" lower seat is book");
                else
                    throw new Ageexception();

            } 
            catch(FormatException n)
            {
                Console.WriteLine(n);
            }
            
            finally
            {
                Console.WriteLine("Ticket is book");
            }
        }
    }
}
