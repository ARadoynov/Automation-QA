using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("atanasradoynov@gmail.com")]
    [TestCase("atanas98radoynov@gmail.com")]
    [TestCase("atanas.radoynov@gmail.com")]
    [TestCase("atanas_radoynov@gmail.com")]
    [TestCase("atanas%radoynov@gmail.com")]
    [TestCase("atanas+radoynov@gmail.com")]
    [TestCase("atanas-radoynov@gmail.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    
    [TestCase("atanasradoynovgmail.com")]
    [TestCase("atanasradoynov@gmailcom")]
    [TestCase("atanasradoynov@gmail.c")]
    [TestCase("atanasradoynov@gmail/com")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
