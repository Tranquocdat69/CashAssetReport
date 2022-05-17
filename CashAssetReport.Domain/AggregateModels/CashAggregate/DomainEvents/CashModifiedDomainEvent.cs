namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Domain.AggregateModels.CashAggregate.DomainEvents
{
    public class CashModifiedDomainEvent : BaseDomainEvent
    {
        public Cash Cash { get; set; }

        public CashModifiedDomainEvent(Cash cash)
        {
            Cash = cash;
        }
    }
}
