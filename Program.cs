using System;

namespace hello_Sharp
{
    class Program
    {
        // entry point of program
        static void Main(string[] args)
        {
            // declaring a variable
            int num1;

            // assign value to variable
            num1 = 13;
            // declaring and initializing a variable in one go
            int num2 = 11;
            int sum = num1 + num2;

            // using concatination
            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);
            Console.Read();
        }
    }
}
