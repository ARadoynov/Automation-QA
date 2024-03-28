using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] emptyWords = Array.Empty<string>();

        // Act
        string result = OddOccurrences.FindOdd(emptyWords);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] words = new string[] { "the", "the" };

        // Act
        string result = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] words = new string[] { "the" };

        // Act
        string result = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(result, Is.EqualTo("the"));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] words = new string[] { "the", "the", "the", "best" };

        // Act
        string result = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(result, Is.EqualTo("the best"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] words = new string[] { "thE", "the", "the", "beSt", "best", "best" };

        // Act
        string result = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(result, Is.EqualTo("the best"));
    }
}
