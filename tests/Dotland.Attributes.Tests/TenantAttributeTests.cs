using FluentAssertions;

namespace Dotland.Attributes.Tests;

public class TenantAttributeTests
{
    [Fact]
    public void TenantAttributeShouldRender()
    {
        const string tenantName = "fake tenant";
        var attribute = new TenantAttribute(tenantName);

        attribute.Should().NotBeNull();
        attribute.Tenant.Should().Be(tenantName);
    }
}