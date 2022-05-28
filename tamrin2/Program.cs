using System;

namespace tamrin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lotfan yek adad vared konid : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int fazayekhali = n - 1 - i;
                for (int j = 0; j < fazayekhali; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write(k + 1);
                }

                for (int k = i; k >= 1 ; k--)
                {
                    Console.Write(k);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}