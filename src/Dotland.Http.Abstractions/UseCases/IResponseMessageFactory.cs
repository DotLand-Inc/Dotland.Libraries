using Dotland.Http.Abstractions.Models.Responses;

namespace Dotland.Http.Abstractions.UseCases;

public interface IResponseMessageFactory
{
    Response Success();
    Response Failure(string errorCode, string errorMessage, string? supportId);
    Response Failure(List<(string errorCode, string errorMessage, string? supportId)> errors);
    Response Failure(List<Message> errorMessages);
}

public interface IResponseMessageFactory<T> : IResponseMessageFactory
    where T : class, new()
{
    Response<T> Success(T messages);
    Response<T> Success(T data, List<Message> messages);
}