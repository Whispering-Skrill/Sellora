using Microsoft.EntityFrameworkCore;
using Sellora.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace Sellora.Server.Configurations.Entities
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
            new Category
            {
                Id = 1,
                CategoryName = "Technology",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Category
            {
                Id = 2,
                CategoryName = "Fashion",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"


            }
        );
        }
    }
}
