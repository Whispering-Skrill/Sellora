using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sellora.Shared.Domain;

namespace Sellora.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        // This seeds the Staff Entity with 2 of the lead developers within the organisation
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
                    StaffDepartment = "Full Stack Development",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
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
                    StaffDepartment = "Full Stack Development",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 3,
                    StaffFirstName = "Emily",
                    StaffLastName = "Ng",
                    StaffEmail = "emily.ng@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Senior UI/UX Designer",
                    StaffAddress = "Design Avenue",
                    StaffHPNum = "88882222",
                    StaffDepartment = "User Experience Design",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 4,
                    StaffFirstName = "Daniel",
                    StaffLastName = "Liu",
                    StaffEmail = "daniel.liu@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Database Administrator",
                    StaffAddress = "Data Center Lane",
                    StaffHPNum = "77773333",
                    StaffDepartment = "Database Management",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
