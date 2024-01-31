using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sellora.Shared.Domain;

namespace Sellora.Server.Configurations.Entities
{
    public class ItemSeedConfiguration : IEntityTypeConfiguration<Item>
    {
        // This seeds the Staff Entity with 2 of the lead developers within the organisation
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasData(
                new Item
                {
                    Id = 1,
                    ItemName = "Tofu65 Keyboard",
                    ItemPrice = 200,
                    Condition = "Well Used",
                    ItemDate = DateTime.Now,
                    ItemDescription = "Very good Keyboard, Served me for many years. Hope to find a new good owner for it.",
                    ItemLocation = "Tampines West Street 42",
                    ImageUrl = "https://via.placeholder.com/300",
                    ItemLikes = 23,
                    ItemClicks = 1334,
                    ItemStatus = 1,
                    CategoryId = 4,
                    AppUserId = 1
                }
            );
        }
    }
}
