using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if(s == "" || s == null)
                return 0;

            int cnt = 0;
            for(int x = 0; x < s.Length; x++)
            {
                if(Char.IsUpper(s[x]))
                    cnt++;
            }
            return cnt + 1;
        }
    }
}
