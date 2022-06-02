using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("yek ada bozorg entekhb konid :");
            // ulong x = Convert.ToUInt64(Console.ReadLine());
            // Console.WriteLine("az 1 ta 9 yek adad entekhb konid: ");
            // uint y = Convert.ToUInt16(Console.ReadLine());
            // ulong count = 0, z;
            // while (x > 0)
            // {
            //     z = x % 10;
            //     if (z == y)
            //     {
            //         count++;
            //     }
            //     x = x / 10;
            // }
            // Console.WriteLine($"Tedad Tekrar : { count}");

            // روش دوم
            Console.WriteLine("yek ada bozorg entekhb konid: ");
            ulong x = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("az 1 ta 9 yek adad entekhb konid :");
            int y = Convert.ToInt32(Console.ReadLine());
            int tekrar = 0;
            foreach (int i in x.ToString())
            {
               foreach (int j in y.ToString())
               {

                   if (i == j)
                   {
                       tekrar++;

                   }
               }
            }

            Console.WriteLine($"tedad tekrar adad entekhbi : {tekrar}");

        }

    }
}
