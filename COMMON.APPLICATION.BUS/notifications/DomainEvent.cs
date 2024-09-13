namespace COMMON.APPLICATION.BUS
{
    /// <summary>
    /// Representa un evento de dominio
    /// </summary>
    public class DomainEvent : IRequestNotification
    {
        public DateTime EventDateUtc { get; private set; }

        public DomainEvent()
        {
            EventDateUtc = DateTime.UtcNow;
        }

        public DomainEvent(DateTime eventDateUtc)
        {
            EventDateUtc = eventDateUtc;
        }
    }
}
