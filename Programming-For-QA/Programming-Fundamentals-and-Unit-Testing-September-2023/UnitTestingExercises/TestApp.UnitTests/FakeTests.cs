using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        //Arrange
        char[] charsArr = new char[] { '1', 'B', };

        //Act
        char[] result = Fake.RemoveStringNumbers(charsArr);

        //Assert
        Assert.That(result, Is.EqualTo(new[] { 'B' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        //Arrange
        char[] charsArr = new char[] { 'A', 'B', };

        //Act
        char[] result = Fake.RemoveStringNumbers(charsArr);

        //Assert
        Assert.That(result, Is.EqualTo(new[] { 'A', 'B', }));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        char[] emptyArr = Array.Empty<char>();

        //Act
        char[] result = Fake.RemoveStringNumbers(emptyArr);

        //Assert
        Assert.That(result, Is.EqualTo(emptyArr));
    }
}
