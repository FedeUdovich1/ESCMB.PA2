using MediatR;

namespace COMMON.APPLICATION.BUS
{
    public interface IRequestCommand : IRequest
    {
    }

    public interface IRequestCommand<out TResponse> : IRequest<TResponse>
    {
    }
}
