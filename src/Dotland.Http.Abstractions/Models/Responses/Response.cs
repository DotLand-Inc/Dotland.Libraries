using System.Runtime.Serialization;

namespace Dotland.Http.Abstractions.Models.Responses;

[DataContract]
public class Response : BaseResponse
{
    /// <summary>
    /// Gets or Sets Meta
    /// </summary>
    [DataMember(Name = "meta")]
    public Meta? Meta { get; set; }
}

public class Response<T> : Response
{
    /// <summary>
    /// Data
    /// </summary>
    [DataMember(Name = "data")]
    public T? Data { get; set; }
}