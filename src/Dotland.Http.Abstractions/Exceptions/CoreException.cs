namespace Dotland.Http.Abstractions.Exceptions;

public class CoreException : Exception
{
    public CoreException(Enum errCode)
    {
        Code = errCode;
    }

    public CoreException(Enum errCode, string message)
    {
        Code = errCode;
    }

    public CoreException(Enum errCode, Exception innerException)
    {
        Code = errCode;
    }

    public Enum Code { get; }
}