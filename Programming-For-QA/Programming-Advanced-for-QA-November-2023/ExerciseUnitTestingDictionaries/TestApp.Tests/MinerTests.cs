using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] emptyInput = Array.Empty<string>();
        // Act
        string result = Miner.Mine(emptyInput);
        
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] minerals = { "Gold 8", "silveR 30" };

        // Act
        string result = Miner.Mine(minerals);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] minerals = { "Gold 4", "silveR 25", "silver 5", "gold 4" };

        // Act
        string result = Miner.Mine(minerals);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }
}
