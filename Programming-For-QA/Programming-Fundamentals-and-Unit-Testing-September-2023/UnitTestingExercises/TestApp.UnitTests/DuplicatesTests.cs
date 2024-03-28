using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.Empty);

    }

    
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new int[] {1, 2 ,3 ,4};
        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(new[] {1, 2, 3, 4}));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 2, 4 };
        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(new[] { 1, 2, 4 }));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = new int[] { 2, 2, 2, 2 };
        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(new[] { 2 }));
    }
}
