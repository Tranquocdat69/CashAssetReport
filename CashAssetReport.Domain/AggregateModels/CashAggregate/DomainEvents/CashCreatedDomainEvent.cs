namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Domain.AggregateModels.CashAggregate.DomainEvents
{
    public class CashCreatedDomainEvent : BaseDomainEvent
    {
        public Cash Cash { get; set; }

        public CashCreatedDomainEvent(Cash cash)
        {
            Cash = cash;
        }
    }
}
