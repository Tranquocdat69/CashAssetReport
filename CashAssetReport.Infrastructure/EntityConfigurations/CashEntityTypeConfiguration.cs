namespace FPTS.FIT.BDRD.CashAssetReport.Services.CashAssetReport.Infrastructure.EntityConfigurations
{
    public class CashEntityTypeConfiguration : IEntityTypeConfiguration<Cash>
    {
        public void Configure(EntityTypeBuilder<Cash> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("TBCTS_CASH_ALL");

            entityTypeBuilder.HasKey(c => c.ClientCode)
                .HasName("ACLIENTCODE");

            entityTypeBuilder.Ignore(c => c.Id);
            entityTypeBuilder.Ignore(c => c.DomainEvents);

            entityTypeBuilder.Property(o => o.ClientCode)
                .HasColumnName("ACLIENTCODE")
                .HasColumnType("VARCHAR2(10 CHAR)");

            entityTypeBuilder.Property(o => o.PurchasingPowerTotal)
                .HasColumnName("APURCHASE_POWER")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.CashAmount)
                .HasColumnName("ACASH_AMOUNT")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.AdvanceAmount)
                .HasColumnName("AADVANCE_AMOUNT")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.RemainingBuyingPower)
                .HasColumnName("APURCHASE_POWER_SEC")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.PendingBuyCash)
                .HasColumnName("APENDING_BUY_CASH")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.MatchedBuyCash)
                .HasColumnName("AMATCH_BUY_CASH")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.TransferringAmount)
                .HasColumnName("ATRANS_AMOUNT")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.RemainingCashAmount)
                .HasColumnName("AREMAIN_CASH_AMOUNT")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.RemainingDebt)
                .HasColumnName("AREMAIN_DEBT")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.DebtInterest)
                .HasColumnName("ADEBT_INTEREST")
                .HasColumnType("NUMBER")
                .IsRequired(false);

             entityTypeBuilder.Property(o => o.ReceivableCashT0)
                .HasColumnName("AREC_CASH_T0")
                .HasColumnType("NUMBER")
                .IsRequired(false);

             entityTypeBuilder.Property(o => o.ReceivableCashT1)
                .HasColumnName("AREC_CASH_T1")
                .HasColumnType("NUMBER")
                .IsRequired(false);

             entityTypeBuilder.Property(o => o.ReceivableCashT2)
                .HasColumnName("AREC_CASH_T2")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.ReceivableMatureCW)
                .HasColumnName("ARE_MATURE_CW")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.ReceivableCashOddlot)
                .HasColumnName("ARE_CASH_ODDLOT")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.ReceivableCashDevidend)
                .HasColumnName("ARE_CASH_DEVIDEND")
                .HasColumnType("NUMBER")
                .IsRequired(false);

            entityTypeBuilder.Property(o => o.Fees)
                .HasColumnName("AFEES")
                .HasColumnType("NUMBER")
                .IsRequired(false);
        }
    }
}
