using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;
        for(; i < n; i++)
        {
            try //Write every item in list
            {
                Console.WriteLine(myList[i]);
            }
            catch //return count to print at end
            {
                return i;
            }
        }
        return i;
    }
}