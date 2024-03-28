using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> wordsList = new List<string>() {"dad"};

        // Act
        bool result = Palindrome.IsPalindrome(wordsList);

        // Assert
        Assert.IsTrue(result);
    }

    
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> wordsList = new();

        // Act
        bool result = Palindrome.IsPalindrome(wordsList);

        // Assert
        Assert.IsTrue(result);

    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> wordsList = new List<string>() { "dad" };

        // Act
        bool result = Palindrome.IsPalindrome(wordsList);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> wordsList = new List<string>() { "bed" };

        // Act
        bool result = Palindrome.IsPalindrome(wordsList);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> wordsList = new List<string>() { "dad", "mom" };

        // Act
        bool result = Palindrome.IsPalindrome(wordsList);

        // Assert
        Assert.IsTrue(result);
    }
}
