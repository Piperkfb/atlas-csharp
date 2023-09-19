using System;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            int x = 0;
            int cnt = s.Count();

            for(x = 0; x <= cnt; x++)
            {
                char Spot = s[x];
                int c = 0;
                foreach(char i in s)
                {
                    if(Spot == i);
                    {
                        c += 1;
                        break;
                    }
                    else
                        continue;
                }
                if(c == 0)
                    return x;
            }
            return -1;
        }
    }
}