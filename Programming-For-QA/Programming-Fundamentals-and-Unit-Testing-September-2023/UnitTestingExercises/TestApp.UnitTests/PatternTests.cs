using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        //Arrange
        int[] numsArr = new int[] { 1, 2, 3, 3, 4 ,5 };

        //Act
        int[] resultArr = Pattern.SortInPattern(numsArr);

        //Assert
        Assert.That(resultArr, Is.EqualTo(new[] { 1, 5, 2, 4, 3 }));
 
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        int[] numsArr = Array.Empty<int>();

        //Act
        int[] resultArr = Pattern.SortInPattern(numsArr);

        //Assert
        Assert.IsEmpty(resultArr);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        //Arrange
        int[] numsArr = new int[] { 1 };

        //Act
        int[] resultArr = Pattern.SortInPattern(numsArr);

        //Assert
        Assert.That(resultArr, Is.EqualTo(new[] { 1 }));
    }
}
