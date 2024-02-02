using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sellora.Shared.Domain;

namespace Sellora.Server.Configurations.Entities
{
    public class ReportSeedConfiguration : IEntityTypeConfiguration<Report>
    {
        // This seeds the Report Entity
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasData(
                new Report
                {
                    Id = 1,
                    ReportDate = DateTime.Now,
                    ReportTitle = "Suspicious Seller!",
                    ReportContent = "When I chatted with this seller, he kept asking me for photos of myself so he can see whether the item is fit for me. A little weird if you ask me...",
                    AppUserID = 10,
                    StaffID = 1,
                    SwapTransactionID = 3,
                    SaleTransactionID = null
                },
                new Report
                {
                    Id = 2,
                    ReportDate = DateTime.Now,
                    ReportTitle = "Buyer ghosted me after making me travel a far distance!",
                    ReportContent = "This buyer just never showed up after deciding on a meeting place. He was online until 5 minutes before the meeting and just MIAed me. Stopped replying after that, but still sees my messages.",
                    AppUserID = 11,
                    StaffID = 2,
                    SwapTransactionID = 5,
                    SaleTransactionID = null
                }
            );
        }
    }
}
