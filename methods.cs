using System;

namespace Methods
{
    class Program
    {
        static void First(string[] args)
        {// METHOD BODY

            /*A method is a code block that contains a series of statements.
             A program causes the statements to be executed,
            by calling the method and specifying any required method arguments.
            
            In C#, every executed instruction is performed in the context of a method.
            The Main method is the entry point for every C# application,
            and is called by common language runtime CLR, when the program is started.
            
             EXAMPLE: 
            ------------------
            public int Add(int num1, int num2) {
              int result = num1 + num2;
              return result;
            }*/
            WriteSomething();

            WriteSomethingSpecific("I am an argument called from a method");
            Console.Read();
        
        }// METHOD BODY END
        //access modifier (static) return type method name (param1, param2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }
        public static void WriteSomethingSpecific(string mytext)
        {
            Console.WriteLine(mytext);
        }
    }
}
