using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleSum;

namespace Fibonacci_numbers
{
    public class Fibonacci_Program
    {
        
        static void Main(string[] args)
        {
            SimpleSum.Program Program = new Program();
            List<int> answer = new List<int>();
            List<int> firstValue = new List<int>();
            List<int> secondValue = new List<int>();

            string stringFirstValue = "1";
            string stringSecondValue = "2";
            Console.WriteLine(stringFirstValue + "\n" + stringSecondValue);
            firstValue = Program.creatingList(stringFirstValue);
            secondValue = Program.creatingList(stringSecondValue);
            
            for (int j = 0; j < 5; j++)
            {
                answer = Program.startList(firstValue, secondValue);
                firstValue = secondValue;
                secondValue = answer;
                for (int i = answer.Count - 1; i >= 0; i--)
                {
                    Console.Write(answer[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
