namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Infrastructure
{
    public class CashAssetReportDbContext : DbContext, IUnitOfWork
    {
        private readonly IMediator _mediator;
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<CashHis> CashHises { get; set; }

        public CashAssetReportDbContext(DbContextOptions options, IMediator mediator) : base(options)
        {
            _mediator = mediator;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();
            modelBuilder.Ignore<BaseDomainEvent>();
            modelBuilder.ApplyConfiguration(new CashEntityTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new CashHisEntityTypeConfiguration());
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEventsAsync(this);
            await base.SaveChangesAsync();

            return true;
        }
    }
}
