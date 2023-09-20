using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Method called Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks for palindrome
        /// </summary>
        /// <param name="s">The string</param>
        /// <returns>True or False</returns>
          public static bool IsPalindrome(string s)
        {
            string s2 = s.ToLower();
            s2 = Regex.Replace(s2, "[:;,. \t\n\r]", "");
            int Length = s2.Length - 1;
            string reverse = "";  

            while(Length>=0)  
            {  
                reverse = reverse + s2[Length];  
                Length--;  
            }
            if (s2 == reverse)
                return true;
            else
                return false;
        }
    }
}