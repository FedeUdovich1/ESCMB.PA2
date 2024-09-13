namespace COMMON.APPLICATION.BUS.queries
{
    /// <summary>
    /// Permite obtener una respuesta paginada a una consulta
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class QueryResult<TEntity> where TEntity : class
    {
        public long Count { get; private set; }
        public IEnumerable<TEntity> Items { get; private set; }
        public uint PageIndex { get; private set; }
        public uint PageSize { get; private set; }

        public QueryResult(IEnumerable<TEntity> items, long count, uint pageSize, uint pageIndex)
        {
            Count = count;
            Items = items;
            PageIndex = pageIndex;
            PageSize = pageSize;
        }
    }
}
