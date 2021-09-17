using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_Sharp
{
    class Program
    {

        // entry point of program
        static void Main(string[] args)
        {
           // Console.ForegroundColor = ConsoleColor.Red;
           // Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Hello Michael");

            //implicit conversion
            int num = 123455566;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.17;
            int myInt;


            // cast double to int;
            // Explicit conversion
            myInt = (int)myDouble;

            // typeConversion
            string myString = myNewDouble.ToString();
            num.ToString();
            string myFloatString = myFloat.ToString();

            bool sunIsShining = true;
            string myBoolString = sunIsShining.ToString();

            string my1stString = "15";
            string my2ndString = "13";
            int num1 = Int32.Parse(my1stString);
            int num2 = Int32.Parse(my2ndString);
            int resultInt = num1 + num2;
            string result = my1stString + my2ndString;

            Console.WriteLine(resultInt);
            Console.WriteLine(result);
            Console.WriteLine(myBoolString);
            Console.WriteLine(myFloatString);
            Console.WriteLine(myInt);
            Console.Read();
        }
    }
}
