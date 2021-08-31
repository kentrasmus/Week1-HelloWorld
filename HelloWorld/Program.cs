using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name!");
            //readline() to read the user input from the console
            string username = Console.ReadLine();
            Console.WriteLine("Hello," + username);

            Console.Read(); 
        }
    }
}
