using System;

namespace pow
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter pow");
            int pow = Convert.ToInt32(Console.ReadLine());
            // روش عادی
            //int result = 1;
            //for (int i = 1; i <= pow; i++)
            //{
            //    result *= number;
            //}
            //Console.WriteLine(result);

            Console.WriteLine(power(number, pow));

            Console.ReadKey();
        }
        static int power(int number, int pow)
        {
            
            //روش دوم
            if (pow > 0)
            {
                return number * power(number, pow-1);
            }
            else
                return 1;
            // روش اول
            //    if (pow == 0)
            //        return 1;
            //    if (pow > 0)
            //    {
            //        return power(number * number,pow,i);
            //    }
            //    else
            //    {
            //        return 1;
            //    }
            //    else if (pow % 2 == 0)
            //    //    return power(number, pow / 2) * power(number, pow / 2);
            //    //else
            //    //    return number * power(number, pow / 2) * power(number, pow / 2);
            //}
        }
    }
}
