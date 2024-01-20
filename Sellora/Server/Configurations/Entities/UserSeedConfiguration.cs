using Sellora.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Sellora.Server.Models;

namespace Sellora.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();
            builder.HasData(
            new AppUser
            {
                Id = 1,
                UserName = "User1",
                UserFirstName = "Seo",
                UserLastName = "Yeong",
                UserEmail = "sy123@gmail.com",
                UserPassword = hasher.HashPassword(null, "P@ssword1"),
                UserHPNum = "88123123",
                UserRegDate = DateTime.Now,
                UserDescription = "",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 2,
                UserName = "User2",
                UserFirstName = "Tina",
                UserLastName = "Tan",
                UserEmail = "tt123@gmail.com",
                UserPassword = hasher.HashPassword(null, "P@ssword2"),
                UserHPNum = "88445566",
                UserRegDate = DateTime.Now,
                UserDescription = "",
                UserLastOnline = DateTime.Now
            }
            );
        }
    }
}
