using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);

            Console.ReadLine();
        }

        /// <summary>
        /// Check the given string if it is a palindrome
        /// </summary>
        /// <param name="s">the given string</param>
        /// <param name="shouldBePalindrome">a boolean value that determines if the given string is a palindrome</param>
        static void Check(string s, bool shouldBePalindrome)
        {
            //Evaluate the given test case
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }

        /// <summary>
        /// A boolean expression that evaluates a given string if it is a palindrome or not.
        /// </summary>
        /// <param name="s">the given string</param>
        /// <returns>true if string is palindrome, otherwise false</returns>
        static bool IsPalindrome(string s)
        {
            //reverse the given string and convert to array of characters
            var stringBuffer = s.Reverse().ToArray();

            //instantiate a new string object with the reversed string
            string s1 = new String(stringBuffer);

            //Compare the reversed string against the unreversed string if they have the same value
            bool result = s1.Equals(s, StringComparison.CurrentCultureIgnoreCase) ? true : false;

            return result;
        }
    }
}
