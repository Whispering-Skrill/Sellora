using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sellora.Shared.Domain;

namespace Sellora.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    StaffFirstName = "Ryan",
                    StaffLastName = "Chong",
                    StaffEmail = "2102197G@student.tp.edu.sg",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Lead Developer",
                    StaffAddress = "Temasek Polytechnic",
                    StaffHPNum = "99991111",
                    StaffDepartment = "Full Stack Development"
                },
                new Staff
                {
                    Id = 2,
                    StaffFirstName = "Lucas",
                    StaffLastName = "Do",
                    StaffEmail = "2203567i@student.tp.edu.sg",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Lead Developer",
                    StaffAddress = "Temasek Polytechnic",
                    StaffHPNum = "99992222",
                    StaffDepartment = "Full Stack Development"
                }
            );
        }
    }
}
