using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program92
{
    internal class Program
    {
        static void Main()
        {
            bool result = ((5 ^ 3 ^ 3) == 5) && ((10 ^ 0) == 10);
            Console.WriteLine(result); // True
        }
    }
}

