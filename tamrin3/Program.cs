
using System;
namespace sum_odd_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pleas your a number ?");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                s = s + i;    
            }
            Console.Write(" jame adad fard = {0}",s );
            Console.ReadKey();
        }
       
    }
}