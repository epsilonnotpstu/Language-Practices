// See https://aka.ms/new-console-template for more information

using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";
            double mydouble = 17.887;
            int myint = (int)mydouble;
            Console.WriteLine(helloWorld.ToUpper()+" "+mydouble+" "+myint);
            Console.WriteLine(Convert.ToString(myint));
            Console.WriteLine(Convert.ToString(mydouble));
            // string username=Console.ReadLine();
            // Console.WriteLine("User name is: "+username.ToUpper());
            // //int age=Console.
            int len=helloWorld.Length;
            Console.WriteLine("Length of string is: "+len);
            string firstName, lastName, name;
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            name=$"My name is {firstName} {lastName}";
            Console.WriteLine(name);
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}

