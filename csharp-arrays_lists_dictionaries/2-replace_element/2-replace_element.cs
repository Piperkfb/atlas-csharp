using System;

class Program
{
    static void PrintArray(int[] array)
    {
        int i;

        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(" ");
        }

        Console.WriteLine();
    }
}