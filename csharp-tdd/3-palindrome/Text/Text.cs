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
            string Forward = "";
            string Backwards = "";
            char[] stringy = s.ToCharArray();
            int count = stringy.Length();

            if(count <= 0)
                return true;
            //for(x = 0; x <= count; x++)
            foreach(char i in s)
            {
                if(Char.IsPunctuation(i) == true)
                    continue;
                else if(Char.IsWhiteSpace(i) == true)
                    continue;
                else
                {
                    Forward = Forward + i;
                }
            }
            Forward = Forward.ToLower();
            Array.Reverse(chars);
            Backwards = new string(chars);
            if(Forward == Backwards)
                return true;
            else
                return false;       
            //Char.IsPunctuation(str[i])
            //Char.IsWhiteSpace(str[i])
            //###.ToLower()
            //.Count()
            //blank = blank + str[i]

        }
    }
}