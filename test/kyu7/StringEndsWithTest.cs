using kata.kyu7;

namespace test.kyu7;

[TestFixture]
public class StringEndsWithTest
{
    private static readonly object[] sampleTestCases =
    [
      new object[] {"samurai", "ai", true},
      new object[] {"sumo", "omo", false},
      new object[] {"ninja", "ja", true},
      new object[] {"sensei", "i", true},
      new object[] {"samurai", "ra", false},
      new object[] {"abc", "abcd", false},
      new object[] {"abc", "abc", true},
      new object[] {"abcabc", "bc", true},
      new object[] {"ails", "fails", false},
      new object[] {"fails", "ails", true},
      new object[] {"this", "fails", false},
      new object[] {"abc", "", true},
      new object[] {":-)", ":-(", false},
      new object[] {"!@#$%^&*() :-)", ":-)", true},
      new object[] {"abc\n", "abc", false},
    ];

    [Test, TestCaseSource(nameof(sampleTestCases))]
    public void SampleTest(string str, string ending, bool expected)
    {
        Assert.That(StringEndWith.Solution(str, ending), Is.EqualTo(expected));
    }
}