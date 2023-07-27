using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Dotland.Http.Abstractions.Models.Enums;

namespace Dotland.Http.Abstractions.Models.Responses;

[DataContract]
public class Meta : BaseResponse
{
    /// <summary>
    /// Define the available statuses when returning a response.  * &#x60;succeeded&#x60; is used when the request has been well processed. It goes along with a http status 20X. * &#x60;partially_succeeded&#x60; is used when the request has been only partially processed for technical or functional reasons (in case of backend unavailability, timeout or unrespected business rule for instance). It goes along with a http status 2xx. and at least one warning message explaining why the request has not been fully processed. * &#x60;failed&#x60; is used when the request has not been successfully processed. If it is for functional reason, it goes along with a http status 4xx; if it is for technical reason, it goes along with a http status 5xx.
    /// </summary>
    /// <value>Define the available statuses when returning a response.  * &#x60;succeeded&#x60; is used when the request has been well processed. It goes along with a http status 20X. * &#x60;partially_succeeded&#x60; is used when the request has been only partially processed for technical or functional reasons (in case of backend unavailability, timeout or unrespected business rule for instance). It goes along with a http status 2xx. and at least one warning message explaining why the request has not been fully processed. * &#x60;failed&#x60; is used when the request has not been successfully processed. If it is for functional reason, it goes along with a http status 4xx; if it is for technical reason, it goes along with a http status 5xx. </value>
    [Required]
    [DataMember(Name = "status")]
    public MetaStatusType? Status { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [DataMember(Name = "messages")]
    public List<Message> Messages { get; set; } = new();
}