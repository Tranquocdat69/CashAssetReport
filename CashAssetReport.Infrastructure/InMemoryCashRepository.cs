namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Infrastructure
{
    public class InMemoryCashRepository : IInMemoryCashRepository
    {
        private IDictionary<string, Cash> _cashInMemory = new Dictionary<string, Cash>();

        public void Add(string id, Cash cash ) => _cashInMemory.Add(id, cash);

        public bool Exist(string id) => _cashInMemory.ContainsKey(id);

        public Cash Get(string id) => _cashInMemory[id];

        public void Clear() => _cashInMemory.Clear();

        public int Count() => _cashInMemory.Count;
    }
}
