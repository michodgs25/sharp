using System;

namespace ChallengeDatatypes
{
    class Program
    {

        static void Main(string[] args)
        {
            // declare and initialize variables with values& log to the console
            int myint = 1245;
            Console.WriteLine(myint);
            bool myBool = true;
            Console.WriteLine(myBool);
            double myDouble = -12.1234250;
            Console.WriteLine(myDouble);
            sbyte mySbyte = -16;
            Console.WriteLine(mySbyte);
            short myShort = -32467;
            Console.WriteLine(myShort);
            uint myUint = 123091;
            Console.WriteLine(myUint);
            long myLong = 12758489449;
            Console.WriteLine(myLong);
            float myFloat = -44.1266F;
            Console.WriteLine(myFloat);

            //create two values of type string
            //convert mystring String to an integer
            string controlString = "I control text";
            string myString = "69";
            int num69 = Int32.Parse(myString);

            //log string type values to console
            Console.WriteLine(controlString);
            Console.WriteLine(myString);
        }
    }
}