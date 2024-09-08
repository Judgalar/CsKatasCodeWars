using kata.kyu6;


namespace test.kyu6;

[TestFixture]
public class StringToCamelCaseTest
{
    [Test]
    public void KataTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(StringToCamelCase.ToCamelCase("the_stealth_warrior"), Is.EqualTo("theStealthWarrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.That(StringToCamelCase.ToCamelCase("The-Stealth-Warrior"), Is.EqualTo("TheStealthWarrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        });
    }
}
