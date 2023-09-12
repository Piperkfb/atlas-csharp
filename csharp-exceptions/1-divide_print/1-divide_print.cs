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
        catch(Exception e)
        {
            //Print error
            Console.WriteLine(e.Message);
        }
        finally
        {
            //Print equation
            Console.WriteLine("{0} / {1} = {2}", a, b, res);
        }
    }
}