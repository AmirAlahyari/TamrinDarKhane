using System;
using System.Collections.Generic;
using System.Linq;

namespace RMlist
{
    class Program
    {
static void Main(string[] args)
        {
            List<string> myList = new List<string> {
                                                       "Parviz",
                                                       "Iria",
                                                       "Peter",
                                                       "Asghar",
                                                       "Pangoilerv",
                                                       "Arin",
                                                       "Asghr"
                                                   };

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***************");

           
            myList.RemoveAll(m => m.StartsWith("Pa"));

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
