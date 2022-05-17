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

        private string _cashAmount;
        public string CashAmount
        {
            get { return _cashAmount; }
            private set { _cashAmount = value; }
        }

        private string _receivableCashT0;
        public string ReceivableCashT0
        {
            get { return _receivableCashT0; }
            private set { _receivableCashT0 = value; }
        }

        private string _receivableCashT1;
        public string ReceivableCashT1
        {
            get { return _receivableCashT1; }
            private set { _receivableCashT1 = value; }
        }

        private string _receivableCashT2;
        public string ReceivableCashT2
        {
            get { return _receivableCashT2; }
            private set { _receivableCashT2 = value; }
        }

        private string _receivableCashSell;
        public string ReceivableCashSell
        {
            get { return _receivableCashSell; }
            private set { _receivableCashSell = value; }
        }

        private string _receivableCashDevidend;
        public string ReceivableCashDevidend
        {
            get { return _receivableCashDevidend; }
            private set { _receivableCashDevidend = value; }
        }

        private string _receivableCashOther;
        public string ReceivableCashOther
        {
            get { return _receivableCashOther; }
            private set { _receivableCashOther = value; }
        }

        private string _totalCash;
        public string TotalCash
        {
            get { return _totalCash; }
            private set { _totalCash = value; }
        }

        private string _remainingDebt;
        public string RemainingDebt
        {
            get { return _remainingDebt; }
            private set { _remainingDebt = value; }
        }

        private string _dateTime;
        public string DateTime
        {
            get { return _dateTime; }
            private set { _dateTime = value; }
        }


    }
}
