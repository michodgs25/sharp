using System;

namespace Lecture
{
	class Lecture
	{
		static void Main(string[] args)
        {
            // declaring a variable
            // int num1;
            // int num2;
            // assign value to variable
            //num1 = 13;
            //num2 = 133;
            // using concatination
            //Console.WriteLine("num1 is " + num1);
            //int sum = num1 + num2;
            //Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);
            // using double numbers
            //double d1 = 3.1415;
            //double d2 = 5.1;
            //double dDiv = d1 / d2;
            //Console.WriteLine("d1/d2 is " + dDiv);
            // using float point numbers
            //float f1 = 3.1415f;
            //float f2 = 5.1f;
            //float fDiv = f1 / f2;
            //Console.WriteLine("f1/f2 is " + fDiv);
            //double dIDiv = d1 / num1;
            //Console.WriteLine("d1/num2 is " + dIDiv);
            //string myname = "Michael";
            //string message = "My name is " + myname;
            //string capsMessage = message.ToUpper();
            //string lowerCaseMessage = message.ToLower();
            //Console.WriteLine(message);
            //Console.WriteLine(lowerCaseMessage);
            //Console.WriteLine(capsMessage);
            //Console.Write("Hey");
            //Console.WriteLine("Hey there");
            //Console.Write("Enter a string and press enter:");
            //string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);
            Console.Write("Enter a string and press enter:");
            
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}:", asciiValue);
            
            Console.ReadKey();
            Console.Read();
        }
    }

}
