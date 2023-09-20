using System;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            if (s == null)
                return -1;
            s = s.ToLower();
            char[] arr = s.ToCharArray();
            int c;
            for(int i=0; i <= arr.Length-1;i++)
            {
                c = 0;
                for(int j=0; j <= arr.Length-1;j++)
                {
                    if (i != j)
                        if(arr[i] == arr[j])
                            c += 1;                    
                }
                if (c == 0)
                    return i;
            }
            return -1;
        }
    }
}