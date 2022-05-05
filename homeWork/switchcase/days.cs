    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace homeWork
    {
        internal class days
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Display days");
                Console.WriteLine("Enter choice between 1-7");
               //  int d = Convert.ToInt32(Console.ReadLine());
                 int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1: Console.WriteLine(choice + " Monday");
                        break;

                    case 2:Console.WriteLine(choice + " Tuesday");
                        break;

                    case 3:Console.WriteLine(choice + " Wednesday");
                        break;

                    case 4:Console.WriteLine(choice + " Thursday");
                        break;

                    case 5:Console.WriteLine(choice + " Friday");
                        break;

                    case 6:Console.WriteLine(choice + " Saturday");
                        break;

                    case 7:Console.WriteLine(choice + " Sunday");
                        break;

                    default:Console.WriteLine("Day does not exit");

                        break;






                }



            }
        }
    }
