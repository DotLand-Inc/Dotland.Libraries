using Dotland.Attributes.Exceptions;
using FluentAssertions;

namespace Dotland.Attributes.Tests.Exceptions;

public class CoreExceptionAttributeTests
{
    [Fact]
    public void CoreExceptionAttributeShouldRender()
    {
        const int httpCode = 200;
        const string description = "description";
        var attribute = new CoreExceptionAttribute(httpCode, description);

        attribute.Should().NotBeNull();
        attribute.Description.Should().Be(description);
    }

    [Fact]
    public void CoreExceptionAttributeWithSingleArgsShouldRender()
    {
        const int httpCode = 200;
        var attribute = new CoreExceptionAttribute(httpCode);

        attribute.Should().NotBeNull();
        attribute.Description.Should().BeNull();
    }
}