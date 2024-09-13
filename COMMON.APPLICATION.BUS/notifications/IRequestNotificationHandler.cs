using MediatR;

namespace COMMON.APPLICATION.BUS
{
    public interface IRequestNotificationHandler<in TNotification> : INotificationHandler<TNotification>
        where TNotification : INotification
    {
    }
}
