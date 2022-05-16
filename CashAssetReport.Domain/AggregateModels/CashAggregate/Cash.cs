namespace CashAssetReport.Domain.AggregateModels.CashAggregate
{
    public class Cash : BaseEntity
    {
        private string _clientCode;
        public string ClientCode
        {
            get { return _clientCode; }
            private set { _clientCode = value; }
        }

        private string _purchasingPowerTotal;
        public string PurchasingPowerTotal
        {
            get { return _purchasingPowerTotal; }
            private set { _purchasingPowerTotal = value; }
        }

        private string _cashAmount;
        public string CashAmount
        {
            get { return _cashAmount; }
            private set { _cashAmount = value; }
        }

        private string _advanceAmount;
        public string AdvanceAmount
        {
            get { return _advanceAmount; }
            private set { _advanceAmount = value; }
        }

        private string _remainingBuyingPower;
        public string RemainingBuyingPower
        {
            get { return _remainingBuyingPower; }
            private set { _remainingBuyingPower = value; }
        }

        private string _pendingBuyCash;
        public string PendingBuyCash
        {
            get { return _pendingBuyCash; }
            private set { _pendingBuyCash = value; }
        }

        private string _matchedBuyCash;
        public string MatchedBuyCash
        {
            get { return _matchedBuyCash; }
            private set { _matchedBuyCash = value; }
        }

        private string _transferringAmount;
        public string TransferringAmount
        {
            get { return _transferringAmount; }
            private set { _transferringAmount = value; }
        }

        private string _remainingCashAmount;
        public string RemainingCashAmount
        {
            get { return _remainingCashAmount; }
            private set { _remainingCashAmount = value; }
        }

        private string _remainingDebt;
        public string RemainingDebt
        {
            get { return _remainingDebt; }
            private set { _remainingDebt = value; }
        }

        private string _debtInterest;
        public string DebtInterest
        {
            get { return _debtInterest; }
            private set { _debtInterest = value; }
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

        private string _receivableMatureCW;
        public string ReceivableMatureCW
        {
            get { return _receivableMatureCW; }
            private set { _receivableMatureCW = value; }
        }

        private string _receivableCashOddlot;
        public string ReceivableCashOddlot
        {
            get { return _receivableCashOddlot; }
            private set { _receivableCashOddlot = value; }
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

        private string _receivableCashTotal;
        public string ReceivableCashTotal
        {
            get { return _receivableCashTotal; }
            private set { _receivableCashTotal = value; }
        }

        private string _fees;
        public string Fees
        {
            get { return _fees; }
            private set { _fees = value; }
        }

        private string _netAssetValue;
        public string NetAssetValue
        {
            get { return _netAssetValue; }
            private set { _netAssetValue = value; }
        }


    }
}
