using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        string[] emptyBrackets = Array.Empty<string>();
        bool isBallanced = BalancedBrackets.IsBalanced(emptyBrackets);
        Assert.IsTrue(isBallanced);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        string[] balancedBrackets = new string[] { "(", ")", "(", ")" };
        bool isBalanced = BalancedBrackets.IsBalanced(balancedBrackets);
        Assert.IsTrue(isBalanced);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        string[] balancedBrackets = new string[] { ")", "(" };
        bool isBalanced = BalancedBrackets.IsBalanced(balancedBrackets);
        Assert.IsFalse(isBalanced);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        string[] balancedBrackets = new string[] { ")", "(", ")" };
        bool isBalanced = BalancedBrackets.IsBalanced(balancedBrackets);
        Assert.IsFalse(isBalanced);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        string[] balancedBrackets = new string[] { "(" };
        bool isBalanced = BalancedBrackets.IsBalanced(balancedBrackets);
        Assert.IsFalse(isBalanced);
    }
}
