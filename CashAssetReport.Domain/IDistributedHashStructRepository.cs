namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Domain
{
    public interface IDistributedHashStructRepository<TKey, TValue, TField>
    {
        Task<bool> RemoveAsync(TKey key, TField field);
        Task<TValue> SaveAsync(TKey key, TField field, TValue value);
        Task<TValue> GetValueAsync(TKey key, TField field);
        Task<IEnumerable<TValue>> GetValuesAsync(TKey key);
    }
}
