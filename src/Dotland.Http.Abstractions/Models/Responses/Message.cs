using Dotland.Http.Abstractions.Models.Enums;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dotland.Http.Abstractions.Models.Responses;

/// <summary>
/// Single metadata response message
/// </summary>
[DataContract]
public class Message : BaseResponse
{
    /// <summary>
	/// Unique technical or business code of the message, that you can use to adapt your application behavior or display a translated human readable message.
	/// </summary>
	/// <value>Unique technical or business code of the message, that you can use to adapt your application behavior or display a translated human readable message. </value>
	[Required]
    [DataMember(Name = "code")]
    public string? Code { get; set; }

    /// <summary>
    /// Optional text to provide human readable information concerning the message. It has to be used only by development team to help troubleshooting, and never to display information to end users.
    /// </summary>
    /// <value>Optional text to provide human readable information concerning the message. It has to be used only by development team to help troubleshooting, and never to display information to end users. </value>
    [DataMember(Name = "text")]
    public string? Text { get; set; }

    /// <summary>
    /// Level of severity of a message.  * &#x60;info&#x60; level is used to provide diagnostics information concerning the process of the request. * &#x60;warn&#x60; level is used to inform that the process of the request has been partially done, because it didn&#x27;t respect all the business rules, or a part of the request has not be successfully processes. * &#x60;error&#x60; level is used to inform that the process of the request met a blocking internal error or business rule, cancelling the request process.
    /// </summary>
    /// <value>Level of severity of a message.  * &#x60;info&#x60; level is used to provide diagnostics information concerning the process of the request. * &#x60;warn&#x60; level is used to inform that the process of the request has been partially done, because it didn&#x27;t respect all the business rules, or a part of the request has not be successfully processes. * &#x60;error&#x60; level is used to inform that the process of the request met a blocking internal error or business rule, cancelling the request process. </value>
    [Required]
    [DataMember(Name = "level")]
    public MessageLevel? Level { get; set; }

    /// <summary>
    /// Optional information providing context information about the origin of the message. For example, for a complex request body, provides the object reference associated to the raised error code.
    /// </summary>
    /// <value>Optional information providing context information about the origin of the message. For example, for a complex request body, provides the object reference associated to the raised error code. </value>
    [DataMember(Name = "ref")]
    public string? @Ref { get; set; }
}