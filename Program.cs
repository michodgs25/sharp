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

            // convert string to integers
            string my1stString = "15";
            string my2ndString = "13";
            int num1 = Int32.Parse(my1stString);
            int num2 = Int32.Parse(my2ndString);
            int resultInt = num1 + num2;
            string result = my1stString + my2ndString;

            // define two variables
            int age = 25;
            string name = "Michael";
            string occupation = "Programmer";
            int length = 1;

            //1. string concatenation 
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");

            //2. String formatting
            //string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old , I work as a {2} and I have been for over {3} year.", name, age, occupation, length);

            //3. String interpolation
            // variables like this {variablesName}
            Console.WriteLine("StringInterpolation");
            Console.WriteLine($"My name is {name}, I am {age} years old, I work as a {occupation} and I have been doing this for over {length} year.");

            //4. Verbatim strings
            //literally and ignore any spaces& escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                                Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                                when an unknown printer took a galley of type and scrambled it to make a type specimen book. 
                                
                                It has survived not only five centuries, 
                                but also the leap into electronic typesetting,
                                remaining essentially unchanged. 
                                
                                It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
                                and more recently with desktop publishing software
                                like Aldus PageMaker including versions of Lorem Ipsum."
                                );
            //instead of using \\ to write file paths we can use verbatim strings to make it easier
            //if you remove the @ you will get an error because \U , \A and \D are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super CoolDog.png");

            //with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Muhahaha \n you have no powers here.");

            string verifyName;
            Console.WriteLine("Please enter your name and press enter:");
    
            string readInput = Console.ReadLine();
            verifyName = readInput;
            Console.WriteLine("You have entered", readInput);


            //Console.WriteLine(resultInt);
            //Console.WriteLine(result);
            //Console.WriteLine(myBoolString);
            //Console.WriteLine(myFloatString);
            //Console.WriteLine(myInt);
            Console.Read();
        }
    }
}
