using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Sellora.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration :
   IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        // This seeds the Identity user role, it gives each application user identity a role, and thus the privileges associated with the role
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            },
            new IdentityUserRole<string>
            {
                RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                UserId = "b1675205-1948-44ec-8b55-b0cb71d1f84e"
            }
            );
        }
    }
}