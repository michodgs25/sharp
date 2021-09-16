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
      
            num2 = 100;
            
            // using concatination
            Console.WriteLine("num1 is " + num1);
            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            // using double numbers
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            // using float point numbers
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num2 is " + dIDiv);

            // declaring multiple variables at once
            Console.Read();
        }
    }
}
