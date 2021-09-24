using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsC
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;
    

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", ++num);

            //decrement operator
            int Decnum = 5;
            Decnum--;
            Console.WriteLine("num is {0}", Decnum);
            Console.WriteLine("num is {0}", Decnum--);
            Console.WriteLine("num is {0}", --Decnum);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;

            Console.WriteLine("Result of num1 < num2 is {0}", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num2 is {0}", isEqual);

            //conditional operators
            //AND OPERATOR &&
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);
            //OR OPERATOR ||
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);




            Console.ReadKey();
        }
    }
}