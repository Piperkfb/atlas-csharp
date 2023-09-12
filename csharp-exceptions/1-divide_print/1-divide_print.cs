using System;

class Int
{
    public static void divide(int a, int b)
    {
        int res = 0;

        try //attempt division
        {
            res = a / b;    
        }
        catch
        {
            //Print error
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            //Print equation
            Console.WriteLine("{0} / {1} = {2}", a, b, res);
        }
    }
}