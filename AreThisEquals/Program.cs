using System;
using System.Collections.Generic;
using System.Linq;
namespace YourProject.Extensions
{
    public static class ListExtensions
    {
        static void Main(string[] args)
        {

            List<string> list1 = new List<string>() { "amir","alahyari"};
            List<string> list2 = new List<string>() { "amir","alahyari"};
          var areEqule =  AreEqule<string>(list1, list2);
            Console.WriteLine(areEqule);
        }
        public static bool AreEqule<T>(List<T> lst1, List<T> lst2)
            where T : IEquatable<T>
        {
            if (lst1.Except(lst2).Any())
                return false;
            if (lst2.Except(lst1).Any())
                return false;
            return true;
        }
    }
}