namespace COMMON.APPLICATION.BUS
{
    /// <summary>
    /// Permite hacer la solicitud de una consulta o querie paginada
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public class QueryRequest<TResponse> : IRequestQuery<TResponse>
        where TResponse : class
    {
        public uint PageIndex { get; set; }
        public uint PageSize { get; set; }
    }
}
