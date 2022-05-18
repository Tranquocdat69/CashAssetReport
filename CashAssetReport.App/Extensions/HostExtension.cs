using Microsoft.EntityFrameworkCore;

namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.App.Extensions
{
    public static class HostExtension
    {
        public static IHost UseHostConfiguration(this IHost host)
        {
            host.InitLoadingDataFromDbToMemory<CashAssetReportDbContext>((context, sp) =>
            {
                var inMemoryCashRepository = sp.GetRequiredService<IInMemoryCashRepository>();
                var logger = sp.GetRequiredService<ILogger<InMemoryCashLoading>>();
                new InMemoryCashLoading().AddDataToMemory(context, inMemoryCashRepository, logger);
            });
            return host;
        }

        private static IHost InitLoadingDataFromDbToMemory<TContext>(this IHost host, Action<TContext, IServiceProvider> action) where TContext : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<TContext>>();
                var context = services.GetRequiredService<TContext>();
                try
                {
                    logger.LogInformation("Migrating database associated with context {DbContextName}", typeof(TContext).Name);
                    action(context, services);
                    logger.LogInformation("Migrated database associated with context {DbContextName}", typeof(TContext).Name);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred while migrating the database used on context {DbContextName}", typeof(TContext).Name);
                }
            }
            return host;
        }
    }
}
