using MediatR;

namespace COMMON.APPLICATION.BUS
{
    public interface IRequestQuery : IRequest
    {
    }

    public interface IRequestQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
