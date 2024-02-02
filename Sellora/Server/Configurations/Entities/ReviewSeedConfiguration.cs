using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sellora.Shared.Domain;

namespace Sellora.Server.Configurations.Entities
{
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        // This seeds the Review Entity
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    Id = 1,
                    ReviewTitle = "Loved the Vintage Jacket!",
                    ReviewRating = 5,
                    ReviewDate = DateTime.Now,
                    ReviewDescription = "The vintage jacket I acquired is a true gem that exudes a sense of timeless style and character.",
                    SwapTransactionID = 2,
                    SaleTransactionID = null,
                    AppUserID = 1
                },
                new Review
                {
                    Id = 2,
                    ReviewTitle = "Terrible Seller!",
                    ReviewRating = 0,
                    ReviewDate = DateTime.Now,
                    ReviewDescription = "This guy sold me a BROKEN Camping Set. What kind of camping stove is one time use only? AND ITS USED. I asked for a refund and the guy just responded with: Googoo gaga not my problem. Like what kind of response is that????!?!!",
                    SwapTransactionID = 5,
                    SaleTransactionID = null,
                    AppUserID = 15
                },
                new Review
                {
                    Id = 3,
                    ReviewTitle = "Great Camera Lens all around! Slow delivery sadly...",
                    ReviewRating = 4,
                    ReviewDate = DateTime.Now,
                    ReviewDescription = "The camera lens was delivered to me 4 days after the estimated and guaranteed delivery date. Missed my daughter's 1st birthday. Fortunately I had my Ophone 19 pro max ultra slim exponential maximum ultimate phone.",
                    SwapTransactionID = 3,
                    SaleTransactionID = null,
                    AppUserID = 10
                }
            );
        }
    }
}
