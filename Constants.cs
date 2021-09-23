using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
//Constants are immutable values
//which are known at compile time
// and do not change for the life of the program
{
    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "27/09/1995";
        static void Main(string[] args)
        {
            Console.WriteLine("My birthday always going to be: {0}", myBirthday);
        }
    }
}