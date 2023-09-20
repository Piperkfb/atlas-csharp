using System;
/// <summary>
/// Class Obj
/// </summary>
public class Obj
{
    /// <summary>
    /// Print Props and MEthods
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        string className = myObj.GetType().Name;

        Console.WriteLine("{0} Properties:", className);
        foreach (var item in myObj.GetType().GetProperties())
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("{0} Methods:", className);
        foreach (var item in myObj.GetType().GetMethods())
        {
            Console.WriteLine(item.Name)
        }
    }
}