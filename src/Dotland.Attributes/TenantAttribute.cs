namespace Dotland.Attributes;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
public sealed class TenantAttribute : Attribute
{
    public string Tenant { get; }

    public TenantAttribute(string tenant)
    {
        Tenant = tenant;
    }
}