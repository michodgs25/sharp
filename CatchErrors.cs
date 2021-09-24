using System;

namespace TryAndCatchC
{
    class Program
    {
        static void Fifth(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by 0.");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
               Console.WriteLine("Format exception, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, number too long");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty.");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }


            Console.ReadKey();
        }
  
    }
}
