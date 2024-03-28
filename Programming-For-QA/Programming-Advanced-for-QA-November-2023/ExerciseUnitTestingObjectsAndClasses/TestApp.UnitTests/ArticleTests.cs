using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        this._article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articleData = 
        {
            "Article Content Author", 
            "Article2 Content2 Author2", 
            "Article3 Content3 Author3",
        };

        // Act
        Article result = _article.AddArticles(articleData);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange

        Article inputArticle = new Article()
        {
            ArticleList = new List<Article>()
            {
            new Article()
                {

                Title = "Article",
                Content = "Content",
                Author = "Author"
                },
            new Article()
        {
                Title = "Article12",
                Content = "Content2",
                Author = "Author2"
        },
            new Article()
        {
                Title = "Article123",
                Content = "Content3",
                Author = "Author3"
        },
    }
};
            
        

        string expected =
        
            $"Article - Content: Author{Environment.NewLine}" +
            $"Article12 - Content2: Author2{Environment.NewLine}" +
            $"Article123 - Content3: Author3";

        // Act
        string actual = _article.GetArticleList(inputArticle, "title");

        // Assert
        Assert.AreEqual(expected, actual);

    }


    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article inputArticle = new Article();
        {

            new Article()
            {

                Title = "Article123",
                Content = "Content",
                Author = "Author"
            };
            new Article()
            {
                Title = "Article12",
                Content = "Content2",
                Author = "Author2"
            };
            new Article()
            {
                Title = "Article1",
                Content = "Content3",
                Author = "Author3"
            };
        };

        string expected =

            $"Article1 - Content: Author{Environment.NewLine}" +
            $"Article12 - Content2: Author2{Environment.NewLine}" +
            $"Article123 - Content3: Author3";

        // Act
        string actual = _article.GetArticleList(inputArticle, "length");

        // Assert
        Assert.That(actual, Is.Empty);
    }
}
