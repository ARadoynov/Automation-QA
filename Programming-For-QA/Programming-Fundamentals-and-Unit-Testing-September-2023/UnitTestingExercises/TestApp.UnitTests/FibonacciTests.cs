using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        
        int n = -1;
        Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int n = 0;
        int result = Fibonacci.CalculateFibonacci(n);
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int n = 7;
        int result = Fibonacci.CalculateFibonacci(n);
        Assert.That(result, Is.EqualTo(13));
    }
}