namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Infrastructure
{
    public class InMemoryCashLoading
    {
        /// <summary>
        /// 2022-05-18 10:10:38 dattq
        /// <para><b>Thêm dữ liệu vào memory</b></para>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="inMemoryOrderRepository"></param>
        /// <param name="logger"></param>
        public void AddDataToMemory(CashAssetReportDbContext context, IInMemoryCashRepository inMemoryOrderRepository, ILogger<InMemoryCashLoading> logger)
        {
            logger.LogInformation("Begin adding data to memory...");
            foreach (var cash in context.Cashes)
            {
                inMemoryOrderRepository.Add(cash.ClientCode, cash);
            }
            Console.WriteLine("Number of cash rows in memory: " + inMemoryOrderRepository.Count());
            logger.LogInformation("End adding data to memory");
        }
    }
}
