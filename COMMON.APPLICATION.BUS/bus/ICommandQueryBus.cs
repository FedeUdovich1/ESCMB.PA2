using MediatR;

namespace COMMON.APPLICATION.BUS
{
    public interface ICommandQueryBus
    {
        Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default)
        where TNotification : INotification;
        Task Send<TRequest>(TRequest request, CancellationToken cancellationToken = default)
        where TRequest : IRequest;
    }
}
