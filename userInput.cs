﻿using System;

namespace Input
{
    class Program
    {
        static void Third(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();
        }
        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number1Input);

            int result = num1 + num2;

            return result;
        }
    }
}

