using System.Text.Json.Serialization;
using System.Text.Json;

namespace Dotland.Http.Abstractions.Models.Responses;

public abstract class BaseResponse
{
    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonSerializer.Serialize(
            this,
            new JsonSerializerOptions()
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase), },
            });
    }
}