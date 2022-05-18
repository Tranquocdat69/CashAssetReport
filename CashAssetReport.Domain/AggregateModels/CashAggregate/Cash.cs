namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Domain.AggregateModels.CashAggregate
{
    public class Cash : BaseEntity, IAggregateRoot
    {
        private string _clientCode;
        public string ClientCode
        {
            get { return _clientCode; }
            private set { _clientCode = value; }
        }

        private decimal? _purchasingPowerTotal;
        public decimal? PurchasingPowerTotal
        {
            get { return _purchasingPowerTotal; }
            private set { _purchasingPowerTotal = value; }
        }

        private decimal? _cashAmount;
        public decimal? CashAmount
        {
            get { return _cashAmount; }
            private set { _cashAmount = value; }
        }

        private decimal? _advanceAmount;
        public decimal? AdvanceAmount
        {
            get { return _advanceAmount; }
            private set { _advanceAmount = value; }
        }

        private decimal? _remainingBuyingPower;
        public decimal? RemainingBuyingPower
        {
            get { return _remainingBuyingPower; }
            private set { _remainingBuyingPower = value; }
        }

        private decimal? _pendingBuyCash;
        public decimal? PendingBuyCash
        {
            get { return _pendingBuyCash; }
            private set { _pendingBuyCash = value; }
        }

        private decimal? _matchedBuyCash;
        public decimal? MatchedBuyCash
        {
            get { return _matchedBuyCash; }
            private set { _matchedBuyCash = value; }
        }

        private decimal? _transferringAmount;
        public decimal? TransferringAmount
        {
            get { return _transferringAmount; }
            private set { _transferringAmount = value; }
        }

        private decimal? _remainingCashAmount;
        public decimal? RemainingCashAmount
        {
            get { return _remainingCashAmount; }
            private set { _remainingCashAmount = value; }
        }

        private decimal? _remainingDebt;
        public decimal? RemainingDebt
        {
            get { return _remainingDebt; }
            private set { _remainingDebt = value; }
        }

        private decimal? _debtInterest;
        public decimal? DebtInterest
        {
            get { return _debtInterest; }
            private set { _debtInterest = value; }
        }

        private decimal? _receivableCashT0;
        public decimal? ReceivableCashT0
        {
            get { return _receivableCashT0; }
            private set { _receivableCashT0 = value; }
        }

        private decimal? _receivableCashT1;
        public decimal? ReceivableCashT1
        {
            get { return _receivableCashT1; }
            private set { _receivableCashT1 = value; }
        }

        private decimal? _receivableCashT2;
        public decimal? ReceivableCashT2
        {
            get { return _receivableCashT2; }
            private set { _receivableCashT2 = value; }
        }

        private decimal? _receivableMatureCW;
        public decimal? ReceivableMatureCW
        {
            get { return _receivableMatureCW; }
            private set { _receivableMatureCW = value; }
        }

        private decimal? _receivableCashOddlot;
        public decimal? ReceivableCashOddlot
        {
            get { return _receivableCashOddlot; }
            private set { _receivableCashOddlot = value; }
        }

        private decimal? _receivableCashDevidend;
        public decimal? ReceivableCashDevidend
        {
            get { return _receivableCashDevidend; }
            private set { _receivableCashDevidend = value; }
        }

        private decimal? _fees;
        public decimal? Fees
        {
            get { return _fees; }
            private set { _fees = value; }
        }

    }
}
