namespace Dotland.Attributes.Exceptions;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class CoreExceptionAttribute : Attribute
{
    public CoreExceptionAttribute(int httpStatus)
    {
        HttpStatus = httpStatus;
    }

    public CoreExceptionAttribute(int httpStatus, string description)
    {
        HttpStatus = httpStatus;
        Description = description;
    }

    public int HttpStatus { get; }
    public string? Description { get; }
}