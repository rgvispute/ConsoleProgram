// See https://aka.ms/new-console-template for more information
using System;
    namespace a
{
    class p
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter height");
            float height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter gender");
            char gender = Convert.ToChar(Console.Read());
            Console.WriteLine("Name\t : \t" + name + "\nAge\t : \t" + age + "\nHeight\t : \t" + height + "\nGender\t : \t" + gender);
        }
    }
}
