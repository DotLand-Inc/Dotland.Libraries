using Dotland.Http.Abstractions.Models.Enums;
using Dotland.Http.Abstractions.Models.Responses;
using Dotland.Http.Abstractions.UseCases;

namespace Dotland.Http.UseCases;

public class ResponseMessageFactory : IResponseMessageFactory
{
    public Response Success() => new()
    {
        Meta = new Meta()
        {
            Messages = new List<Message>(),
            Status = MetaStatusType.Succeeded,
        },
    };

    public Response Failure(string errorCode, string errorMessage, string? supportId)
    {
        var message = new Message()
        {
            Level = MessageLevel.Error,
            Ref = supportId,
            Text = errorMessage,
            Code = errorCode,
        };
        return Failure(new List<Message>() { message });
    }

    public Response Failure(List<(string errorCode, string errorMessage, string? supportId)> errors)
    {
        var messages = errors.Select(m => new Message()
        {
            Code = m.errorCode,
            Text = m.errorMessage,
            Level = MessageLevel.Error,
            Ref = m.supportId,
        }).ToList();

        return Failure(messages);
    }

    public Response Failure(List<Message> errorMessages) => new()
    {
        Meta = new Meta()
        {
            Messages = errorMessages,
            Status = MetaStatusType.Failed,
        }
    };
}

public class ResponseMessageFactory<T> : ResponseMessageFactory, IResponseMessageFactory<T>
    where T : class, new()
{
    public Response<T> Success(T data) => new()
    {
        Meta = new Meta()
        {
            Status = MetaStatusType.Succeeded,
        },
        Data = data,
    };

    public Response<T> Success(T data, List<Message> messages) => new()
    {
        Meta = new Meta()
        {
            Messages = messages,
            Status = MetaStatusType.Succeeded,
        },
        Data = data,
    };
}