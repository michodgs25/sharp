using System;

namespace MethodsTwo
{
    class Program
    {
        static void Second(string[] args)
        {
            // Call Add, Multiply, Divide methods& args, to print statements to console
            Console.WriteLine(Add(Add(1, 5), Add(3, 4)));
            Console.WriteLine(Add(15, 69));
            
            Console.WriteLine(Multiply(5, 5));
            Console.WriteLine(Multiply(Multiply(2, 78), Multiply(56, 2)));

            Console.WriteLine(Divide(6, 42));
            Console.WriteLine(Divide(Divide(4, 100), Divide(56, 2)));

            String friendOne = "Tim";
            String friendTwo = "Neil";
            String friendThree = "Mark";

            Console.WriteLine($"Hi {friendOne}, my friend!");
            Console.WriteLine($"Hi {friendTwo}, my friend!");
            Console.WriteLine($"Hi {friendThree}, my friend!");

            GreetFriend(friendOne);
            GreetFriend(friendTwo);
            GreetFriend(friendThree);
            //Console.WriteLine($"My name is {name}, I am {age} years old, I work as a {occupation} and I have been doing this for over {length} year.");


            Console.Read();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num4, int num5)
        {
            return num4 * num5;
        }
        public static double Divide(double num6, double num7)
        {
            return num6 / num7;
        }
        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + " , my friend!");
        }
    }
}

