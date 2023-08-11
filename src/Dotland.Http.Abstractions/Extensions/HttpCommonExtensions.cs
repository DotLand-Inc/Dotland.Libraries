using System.Reflection;

namespace Dotland.Http.Abstractions.Extensions;

public static class HttpCommonExtensions
{
    public static T? GetCustomAttribute<T>(this Enum value) where T : Attribute
    {
        var type = value.GetType();
        var member = type.GetMember(value.ToString()).FirstOrDefault();

        return member != null ? member.GetCustomAttribute<T>() : null;
    }

    public static string? GetName(this Enum value)
    {
        var type = value.GetType();
        var name = Enum.GetName(type, value);

        return name;
    }
}