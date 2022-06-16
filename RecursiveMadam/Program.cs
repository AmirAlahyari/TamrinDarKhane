using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kalame morede nazar ra vared konid");
            string word = Console.ReadLine();
            Console.WriteLine(ReverseMyWord(word, "", word.Length));
            
            Console.ReadKey();
        }
            
        static string ReverseMyWord(string word, string reversedWord, int i)
        {
            
            if (word.Length %2 ==1 && i > word.Length / 2 + 1)
            {
                i--;
                reversedWord = reversedWord + word[i];
                return ReverseMyWord(word, reversedWord, i);
            }
            else if (word.Length % 2 == 0 && i > word.Length / 2)
            {
                i--;
                reversedWord = reversedWord + word[i];
                return ReverseMyWord(word, reversedWord, i);
            }
            else
            {
                if (reversedWord == word.Substring(0, reversedWord.Length))
                    return "true";
                else
                    return "false";
            };
        }
    }
}
