using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;

            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            } else
            {
                numTemp = 0;
                Console.WriteLine("You didn't enter a valid value - only numbers");
            }


            if (numTemp < 20)
            {
                Console.WriteLine("Take the Coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Trousers and pull over should be fine.");
            }
            else
            {

                Console.WriteLine("Shorts and T-shirt");
                Console.Read();
            }
        }
    }
}