using System;
/// <summary>
/// class ob
/// </summary>
public class Obj
{
    /// <summary>
    /// returns true or false if Array
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}