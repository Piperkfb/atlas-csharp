using System;

/// <summary>
/// obafsg
/// </summary>
public class Obj
{
    /// <summary>
    /// Is it an int?
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}