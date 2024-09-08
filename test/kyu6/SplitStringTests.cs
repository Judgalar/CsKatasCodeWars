using kata.kyu6;
using NUnit.Framework;
using System;

namespace test.kyu6;

[TestFixture]
public class SplitStringTests
{
    [Test]
    public void BasicTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(SplitString.Solution("abc"), Is.EqualTo(new string[] { "ab", "c_" }));
            Assert.That(SplitString.Solution("abcdef"), Is.EqualTo(new string[] { "ab", "cd", "ef" }));
        });
    }
}
