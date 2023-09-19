using NUnit.Framework;
using System;

namespace Text.Tests
{
    [TestFixture]
    public class Basic
    {
        string s = "Heheloo";
        int res = Str.UniqueChar(s);

        Assert.AreEqual(4, res)
    }
    public class NoNonRep
    {
        string s = "aabbccddee"
        int res = Str.UniqueChar(s);

        Assert.AreEqual(-1, res)
    }
    public class Blank
    {
        string s = "";
        int res = Str.UniqueChar(s);

        Assert.AreEqual(-1, res)
    }
}