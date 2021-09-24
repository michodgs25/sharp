using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);


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