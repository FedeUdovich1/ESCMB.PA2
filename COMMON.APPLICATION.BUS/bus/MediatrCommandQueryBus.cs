using MediatR;

namespace COMMON.APPLICATION.BUS
{
    public class MediatrCommandQueryBus : ICommandQueryBus
    {
        private readonly IMediator _mediator;
        public MediatrCommandQueryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Permite el manejo de notificaciones (Eventos de dominio)
        /// </summary>
        /// <typeparam name="TNotification"></typeparam>
        /// <param name="notification"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : INotification
        {
            return _mediator.Publish(notification, cancellationToken);
        }

        /// <summary>
        /// Permite el manejo de comandos y queries
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task Send<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest
        {
            return _mediator.Send(request, cancellationToken);
        }
    }
}
