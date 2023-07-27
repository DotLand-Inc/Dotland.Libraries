using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Dotland.Http.Abstractions.Models.Enums;

/// <summary>
/// Level of severity of a message.  * `info` level is used to provide diagnostics information concerning the process of the request. * `warn` level is used to inform that the process of the request has been partially done, because it didn't respect all the business rules, or a part of the request has not be successfully processes. * `error` level is used to inform that the process of the request met a blocking internal error or business rule, cancelling the request process.
/// </summary>
/// <value>Level of severity of a message.  * `info` level is used to provide diagnostics information concerning the process of the request. * `warn` level is used to inform that the process of the request has been partially done, because it didn't respect all the business rules, or a part of the request has not be successfully processes. * `error` level is used to inform that the process of the request met a blocking internal error or business rule, cancelling the request process. </value>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MessageLevel
{
    /// <summary>
    /// Enum InfoEnum for info
    /// </summary>
    [EnumMember(Value = "info")]
    Info = 0,

    /// <summary>
    /// Enum WarnEnum for warn
    /// </summary>
    [EnumMember(Value = "warn")]
    Warn = 1,

    /// <summary>
    /// Enum ErrorEnum for error
    /// </summary>
    [EnumMember(Value = "error")]
    Error = 2,
}