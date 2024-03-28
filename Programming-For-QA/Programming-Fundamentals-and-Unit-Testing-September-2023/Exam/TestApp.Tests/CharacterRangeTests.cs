using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        char char1 = 'a';
        char char2 = 'b';

        string result = CharacterRange.GetRange(char1, char2);

        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        char char1 = 'b';
        char char2 = 'a';

        string result = CharacterRange.GetRange(char1, char2);

        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        char char1 = 'a';
        char char2 = 'c';

        string result = CharacterRange.GetRange(char1, char2);

        Assert.That(result, Is.EqualTo("b"));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        char char1 = 'd';
        char char2 = 'g';

        string result = CharacterRange.GetRange(char1, char2);

        Assert.That(result, Is.EqualTo("e f"));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        char char1 = 'x';
        char char2 = 'z';

        string result = CharacterRange.GetRange(char1, char2);

        Assert.That(result, Is.EqualTo("y"));
    }
}
