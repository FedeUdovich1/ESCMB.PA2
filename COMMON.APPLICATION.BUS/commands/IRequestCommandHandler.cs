using MediatR;

namespace COMMON.APPLICATION.BUS
{
    public interface IRequestCommandHandler<in TRequest> : IRequestHandler<TRequest>
        where TRequest : IRequest
    {
    }

    public interface IRequestCommandHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
    }
}
