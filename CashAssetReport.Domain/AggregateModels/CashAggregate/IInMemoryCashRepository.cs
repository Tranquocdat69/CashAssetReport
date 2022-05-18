namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Domain.AggregateModels.CashAggregate
{
    public interface IInMemoryCashRepository : IKeyValuePairRepository<Cash, string>
    {
        public int Count();
    }
}
