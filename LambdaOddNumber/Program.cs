using System;
using System.Collections.Generic;

namespace LambdaOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            List<int> lstnumbers = new List<int>();
            while (i < numbers)
            {
                i++;
                lstnumbers.Add(i);
            }
            Console.Write("odd numbers :");

            List<int> oddNumbers = lstnumbers.FindAll(a => a % 2 != 0);
            oddNumbers.ForEach(a => Console.Write(a+" ")); 
        }
    }
}
