namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Domain.AggregateModels.CashHisAggregate
{
    public class CashHis : BaseEntity, IAggregateRoot
    {
        private string _clientCode;
        public string ClientCode
        {
            get { return _clientCode; }
            private set { _clientCode = value; }
        }

        private decimal _cashAmount;
        public decimal CashAmount
        {
            get { return _cashAmount; }
            private set { _cashAmount = value; }
        }

        private decimal _receivableCashT0;
        public decimal ReceivableCashT0
        {
            get { return _receivableCashT0; }
            private set { _receivableCashT0 = value; }
        }

        private decimal _receivableCashT1;
        public decimal ReceivableCashT1
        {
            get { return _receivableCashT1; }
            private set { _receivableCashT1 = value; }
        }

        private decimal _receivableCashT2;
        public decimal ReceivableCashT2
        {
            get { return _receivableCashT2; }
            private set { _receivableCashT2 = value; }
        }

        private decimal _receivableCashDevidend;
        public decimal ReceivableCashDevidend
        {
            get { return _receivableCashDevidend; }
            private set { _receivableCashDevidend = value; }
        }

        private decimal _receivableCashOther;
        public decimal ReceivableCashOther
        {
            get { return _receivableCashOther; }
            private set { _receivableCashOther = value; }
        }

        private decimal _remainingDebt;
        public decimal RemainingDebt
        {
            get { return _remainingDebt; }
            private set { _remainingDebt = value; }
        }

        private DateTime _dateTime;
        public DateTime DateTime
        {
            get { return _dateTime; }
            private set { _dateTime = value; }
        }

    }
}
