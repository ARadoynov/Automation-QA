using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        List<string> urlList = new List<string>(MatchUrls.ExtractUrls(text));

        // Assert
        Assert.That(urlList, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "This is my website -";

        // Act
        List<string> urlList = new List<string>(MatchUrls.ExtractUrls(text));

        // Assert
        Assert.That(urlList, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "This is my website - https://www.facebook.com";
        List<string> expectedUrlList = new() { "https://www.facebook.com" };

        // Act
        List<string> resultUrlList = new List<string>(MatchUrls.ExtractUrls(text));

        // Assert
        Assert.That(resultUrlList, Is.EqualTo(expectedUrlList));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "Those are my websites - https://www.facebook.com https://www.google.com";
        List<string> expectedUrlList = new () { "https://www.facebook.com", "https://www.google.com" };

        // Act
        List<string> resultUrlList = new List<string>(MatchUrls.ExtractUrls(text));

        // Assert
        Assert.That(resultUrlList, Is.EqualTo(expectedUrlList));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "This is my website - \"https://www.facebook.com\"";
        List<string> expectedUrlList = new() { "\"https://www.facebook.com\"" };

        // Act
        List<string> resultUrlList = new List<string>(MatchUrls.ExtractUrls(text));

        // Assert
        Assert.That(resultUrlList, Is.EqualTo(expectedUrlList));
    }
}
