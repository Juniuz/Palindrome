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

        static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }

        static bool IsPalindrome(string s)
        {
            var stringBuffer = s.Reverse().ToArray();
            string s1 = new String(stringBuffer);

            bool result = s1.Equals(s, StringComparison.CurrentCultureIgnoreCase) ? true : false;
            return result;
        }
    }
}
