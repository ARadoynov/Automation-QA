using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act
        string result = Grouping.GroupNumbers(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> emptyList = new List<int>() { 1, 2, 3, 4 };

        // Act
        string result = Grouping.GroupNumbers(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo($"Odd numbers: 1, 3{Environment.NewLine}Even numbers: 2, 4"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> emptyList = new List<int>() { 2, 4, 6, 8 };

        // Act
        string result = Grouping.GroupNumbers(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2, 4, 6, 8"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> emptyList = new List<int>() { 1, 5, 3, 7 };

        // Act
        string result = Grouping.GroupNumbers(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 5, 3, 7"));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> emptyList = new List<int>() { -1, -2, -3, -4 };

        // Act
        string result = Grouping.GroupNumbers(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo($"Odd numbers: -1, -3{Environment.NewLine}Even numbers: -2, -4"));
    }
}
