using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int value1 = 1;
            int value2 = 2;
            int value3;
            while(true)
            {
                value3 = value1 + value2;
                value1 = value2;
                value2 = value3;
                Console.WriteLine(value3);
            }
        }
    }
}
