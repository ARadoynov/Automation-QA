using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        //Arrange
        long number = 1;

        //Act & Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(number), Throws.ArgumentException);

    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long number = 2;
        long result = PrimeFactor.FindLargestPrimeFactor(number);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long number = 4217491274913;
        long result = PrimeFactor.FindLargestPrimeFactor(number);
        Assert.That(result, Is.EqualTo(2719));
    }
}
