using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(" Enter string 1: ");
            // string str1 = Console.ReadLine();

            // Console.WriteLine(" Enter string 1: ");
            // string str2 = Console.ReadLine();

            // if (str1.Length > str2.Length)
            // {
            //     Console.WriteLine("tole reshte aval az reshte dovom bozorgtar ast");
            // }

            // bool yaftshod = false;
            // for (int i = 0; i < str2.Length; i++)
            // {
            //     string matchString = "";
            //     for (int j = 0; j < str1.Length; j++)
            //     {
            //         matchString = matchString + str2[i + j];
            //     }

            //     if (matchString == str1)
            //     {
            //         yaftshod = true;
            //         break;
            //     }
            // }

            // if (yaftshod == true)
            // {
            //     Console.WriteLine("yaft Shooooooood :)");
            // }
            // else
            // {
            //     Console.WriteLine("yaft NNNashoooooood :(");
            // }
            


            Console.WriteLine(" Enter string 1: ");
            string str1 = Console.ReadLine();

            Console.WriteLine(" Enter string 1: ");
            string str2 = Console.ReadLine();

            bool searcheresult = false;
            for (int i = 0; i <str2.length; i++)
            {
                if (str2.substring(i, str1.length)==1)
                {
                    searcheresult =true;
                    break;
                }
            }
            string str =(searcheresult)?$"{str1}"
            Console.WriteLine(str);

        }
    }
}
