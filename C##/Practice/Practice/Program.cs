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
        }
    }
}

