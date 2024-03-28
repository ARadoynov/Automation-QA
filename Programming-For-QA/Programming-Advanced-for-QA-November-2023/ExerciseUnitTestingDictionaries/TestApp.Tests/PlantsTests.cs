using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] emptyInput = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(emptyInput);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] emptyInput = new string[] {"rose"};

        // Act
        string result = Plants.GetFastestGrowing(emptyInput);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 4 letters:{Environment.NewLine}rose"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] emptyInput = new string[] { "rose", "daisy", "cactus" };

        // Act
        string result = Plants.GetFastestGrowing(emptyInput);

        // Assert
        Assert.That(result, Is.EqualTo(
            $"Plants with 4 letters:{Environment.NewLine}rose{Environment.NewLine}" +
            $"Plants with 5 letters:{Environment.NewLine}daisy{Environment.NewLine}" +
            $"Plants with 6 letters:{Environment.NewLine}cactus"));

    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] emptyInput = new string[] { "roSe", "daisY", "cacTus" };

        // Act
        string result = Plants.GetFastestGrowing(emptyInput);

        // Assert
        Assert.That(result, Is.EqualTo(
            $"Plants with 4 letters:{Environment.NewLine}roSe{Environment.NewLine}" +
            $"Plants with 5 letters:{Environment.NewLine}daisY{Environment.NewLine}" +
            $"Plants with 6 letters:{Environment.NewLine}cacTus"));
    }
}
