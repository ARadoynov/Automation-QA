using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    
    [TestCase("nako", 1,"nAkO")]
    [TestCase("nako", 2, "nAkOnAkO")]
    [TestCase("NaKo", 1, "nAkO")]
    [TestCase("NAKO", 5, "nAkOnAkOnAkOnAkOnAkO")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange
        

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        //Arrange
        string input = "";
        int repFactor = 2;

        //Act & Assert
        Assert.That(() =>  Pattern.GeneratePatternedString(input, repFactor), Throws.ArgumentException);

    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "ABC";
        int repFactor = -1;

        //Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "";
        int repFactor = 0;

        //Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repFactor), Throws.ArgumentException);
    }
}
