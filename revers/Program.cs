using System;

namespace reverses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kalame morede nazar ra vared konid");
            string word = Console.ReadLine();
            string reversedWord ="";

            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(word[i]);
            //}
            
            reversedWord = ReverseMyWord(word, reversedWord, word.Length);
            Console.WriteLine(reversedWord);
            
            Console.ReadKey();
        }
            
        static string ReverseMyWord(string word, string reversedWord, int i)
        {
            if (i > 0)
            {
                i--;
                reversedWord = reversedWord+ word[i];
                return ReverseMyWord(word,  reversedWord, i);
            }
            else
            {
                return reversedWord;
            };
        }
    }
}
