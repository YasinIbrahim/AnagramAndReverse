using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreStringsAnagrams
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArr = s.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

        public static string ReverseWords(string s)
        {
            string[] words = s.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public static bool AreStringsAnagrams(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            foreach (char c in a)
            {
                if (b.IndexOf(c) == -1)
                    return false;
                else
                    b.Remove(b.IndexOf(c));
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Original string: 'this is some text'");
            Console.WriteLine("Reversed string: " + Reverse("this is some text"));
            Console.WriteLine("Reversed words: " + ReverseWords("this is some text"));

            Console.Write("Enter string 1: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter string 2: ");
            string word2 = Console.ReadLine();

            Console.WriteLine("Checking if '" + word1 + "' is anagram of '"+word2+"'");
            if (AreStringsAnagrams(word1, word2))
            {
                Console.WriteLine("Strings are anagrams");
            } else {
                Console.WriteLine("Strings are not anagrams");
            }
            
            Console.Write("press any key to quit...");
            Console.ReadKey();

       
        }
    }
}
