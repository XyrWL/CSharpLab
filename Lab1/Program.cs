using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there!");
            Console.WriteLine("The second number is {1} and the first is {0}", 5, 10);
            Console.WriteLine("The next number is a currency {0:C}", 20);
            Console.WriteLine("The next number is pushed further by 10 {0,10}", 40);
            Console.ReadLine();
        }
    }
}
