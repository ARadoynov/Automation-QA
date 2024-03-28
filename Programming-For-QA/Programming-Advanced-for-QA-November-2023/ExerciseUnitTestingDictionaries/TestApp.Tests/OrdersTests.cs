using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] emptyInput = Array.Empty<string>();

        // Act
        string result = Orders.Order(emptyInput);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] products = new string[] 
        {
            "apple 0.50 1",
            "apple 1.99 2",
            "banana 0.75 5",
            "orange 0.99 2"
        };

        // Act
        string result = Orders.Order(products);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] products = new string[]
        {
            "apple 1.00 2",
            "banana 2.00 3",
            "orange 3.00 4" 
        };

        // Act
        string result = Orders.Order(products);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 2.00{Environment.NewLine}banana -> 6.00{Environment.NewLine}orange -> 12.00"));

    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] products = new string[]
        {
            "apple 1.00 2.0",
            "banana 2.00 3.0",
            "orange 3.00 4.0"
        };

        // Act
        string result = Orders.Order(products);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 2.00{Environment.NewLine}banana -> 6.00{Environment.NewLine}orange -> 12.00"));
    }

    [Test]
    public void Test_Order_WithDecimalWrongInput_ShouldThrowException()
    {
        // Arrange
        string[] products = new string[]
        {
            "1.00 banana 2.0",
            "banana 2.00 3.0",
            "orange 3.00 4.0"
        };

        // Act & Assert
        Assert.That(() => Orders.Order(products), Throws.ArgumentException);
    }
}
