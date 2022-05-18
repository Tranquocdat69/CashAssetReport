
namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.App.Extensions
{
    public static class ServiceCollectionExtension
    {
        private const string c_dbConnectionKey = "BCTSDB";

        /// <summary>
        /// 2022-05-18 10:10:38 dattq
        /// <para><b>Phương thức mở rộng cho IServiceCollection</b></para>
        /// </summary>
        /// <param name="configuration">dùng để đọc dữ liệu trong appsettings.json</param>
        public static IServiceCollection UseServiceCollectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddLoggerConfiguration(configuration)
                .AddPersistenceConfiguration(configuration)
                .AddMediatorConfiguration()
                .AddScopedServices();

            return services;
        }

        /// <summary>
        /// 2022-05-18 10:10:38 dattq
        /// <para><b>Đăng kí service với lifetime scoped</b></para>
        /// </summary>
        private static IServiceCollection AddScopedServices(this IServiceCollection services)
        {
            return services.AddScoped<IInMemoryCashRepository, InMemoryCashRepository>();
        }

        /// <summary>
        /// 2022-05-18 10:10:38 dattq
        /// <para><b>Cấu hình logger và kafka logger</b></para>
        /// </summary>
        /// <param name="configuration"></param>
        private static IServiceCollection AddLoggerConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddLogging(options =>
            {
                var allowConsoleLog = configuration.GetValue("AllowConsoleLog", false);
                if (!allowConsoleLog)
                {
                    options.ClearProviders();
                }
                options.AddKafka(configuration.GetSection("KafkaLogger"));
            });
            return services;
        }

        /// <summary>
        /// 2022-05-18 10:10:38 dattq
        /// <para><b>Cấu hình kết nối đến cơ sở dữ liệu</b></para>
        /// </summary>
        /// <param name="configuration"></param>
        private static IServiceCollection AddPersistenceConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var dbConnectionString = configuration.GetConnectionString(c_dbConnectionKey);
            services.AddDbContext<CashAssetReportDbContext>((options) =>
            {
                if (!String.IsNullOrEmpty(dbConnectionString))
                {
                    options.UseOracle(dbConnectionString);
                }
            });
            return services;
        }

        /// <summary>
        /// 2022-05-18 10:10:38 dattq
        /// <para><b>Cấu hình Mediator</b></para>
        /// </summary>
        private static IServiceCollection AddMediatorConfiguration(this IServiceCollection services)
        {
            services
                .AddMediatR(typeof(CashCreatedDomainEvent));
            return services;
        }
    }
}
