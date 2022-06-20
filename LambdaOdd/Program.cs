using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaSumOddNumbe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int EnterNumbers = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();

            numbers.AddRange(Enumerable.Range(0, EnterNumbers));

            List<int> oddNumbers = numbers.FindAll(a => a % 2 != 0);

            oddNumbers.ForEach(a => Console.Write(a + " "));

        }
    }
}
