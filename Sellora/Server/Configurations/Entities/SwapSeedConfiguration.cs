using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sellora.Shared.Domain;

namespace Sellora.Server.Configurations.Entities
{
    public class SwapSeedConfiguration : IEntityTypeConfiguration<SwapTransaction>
    {
        // This seeds the SwapTransaction Entity
        public void Configure(EntityTypeBuilder<SwapTransaction> builder)
        {
            builder.HasData(
                new SwapTransaction
                {
                    Id = 1,
                    TransactionDate = DateTime.Now,
                    AppUser1Id = 1,
                    SwapItem1Id = 1,
                    AppUser2Id = 2,
                    SwapItem2Id = 2
                },
                new SwapTransaction
                {
                    Id = 2,
                    TransactionDate = DateTime.Now,
                    AppUser1Id = 5,
                    SwapItem1Id = 35,
                    AppUser2Id = 7,
                    SwapItem2Id = 67
                },
                new SwapTransaction
                {
                    Id = 3,
                    TransactionDate = DateTime.Now,
                    AppUser1Id = 10,
                    SwapItem1Id = 40,
                    AppUser2Id = 11,
                    SwapItem2Id = 71
                },
                new SwapTransaction
                {
                    Id = 4,
                    TransactionDate = DateTime.Now,
                    AppUser1Id = 11,
                    SwapItem1Id = 71,
                    AppUser2Id = 5,
                    SwapItem2Id = 5
                },
                new SwapTransaction
                {
                    Id = 5,
                    TransactionDate = DateTime.Now,
                    AppUser1Id = 15,
                    SwapItem1Id = 15,
                    AppUser2Id = 19,
                    SwapItem2Id = 40
                }
            );
        }
    }
}
