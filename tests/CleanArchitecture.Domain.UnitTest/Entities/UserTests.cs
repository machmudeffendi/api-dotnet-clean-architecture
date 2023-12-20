using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.UnitTest.Entities;

public class UserTests
{
    [Test]
    public void IsValid_ShouldEqualEmail()
    {
        var user = new User { Email = "test@example.com" };
        var email = user.Email;
        Assert.That(email, Is.EqualTo("test@example.com"));
    }
}