using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Dotland.Http.Abstractions.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MetaStatusType
{
    /// <summary>
    /// Enum SucceededEnum for succeeded
    /// </summary>
    [EnumMember(Value = "succeeded")]
    Succeeded = 0,

    /// <summary>
    /// Enum PartiallySucceededEnum for partially_succeeded
    /// </summary>
    [EnumMember(Value = "partially_succeeded")]
    PartiallySucceeded = 1,

    /// <summary>
    /// Enum FailedEnum for failed
    /// </summary>
    [EnumMember(Value = "failed")]
    Failed = 2,
}