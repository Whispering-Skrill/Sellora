using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sellora.Shared.Domain;

namespace Sellora.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        // This seeds the Staff Entity
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
                },
                new Staff
                {
                    Id = 5,
                    StaffFirstName = "Jessica",
                    StaffLastName = "Wong",
                    StaffEmail = "jessica.wong@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Software Developer",
                    StaffAddress = "Code Street",
                    StaffHPNum = "91112233",
                    StaffDepartment = "Software Engineering",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 6,
                    StaffFirstName = "Ryan",
                    StaffLastName = "Tan",
                    StaffEmail = "ryan.tan@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Network Administrator",
                    StaffAddress = "Connectivity Avenue",
                    StaffHPNum = "92223344",
                    StaffDepartment = "Network Management",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 7,
                    StaffFirstName = "Michelle",
                    StaffLastName = "Ng",
                    StaffEmail = "michelle.ng@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Systems Analyst",
                    StaffAddress = "Tech Park",
                    StaffHPNum = "93334455",
                    StaffDepartment = "System Analysis",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 8,
                    StaffFirstName = "Alex",
                    StaffLastName = "Cheng",
                    StaffEmail = "alex.cheng@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Security Specialist",
                    StaffAddress = "Secure Lane",
                    StaffHPNum = "94445566",
                    StaffDepartment = "Information Security",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 9,
                    StaffFirstName = "Emily",
                    StaffLastName = "Lim",
                    StaffEmail = "emily.lim@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Project Manager",
                    StaffAddress = "Project Street",
                    StaffHPNum = "95556677",
                    StaffDepartment = "Project Management",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 10,
                    StaffFirstName = "Patrick",
                    StaffLastName = "Goh",
                    StaffEmail = "patrick.goh@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "UX/UI Designer",
                    StaffAddress = "Design Avenue",
                    StaffHPNum = "96667788",
                    StaffDepartment = "Design Team",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 11,
                    StaffFirstName = "Vanessa",
                    StaffLastName = "Teo",
                    StaffEmail = "vanessa.teo@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Database Administrator",
                    StaffAddress = "Data Center Lane",
                    StaffHPNum = "97778899",
                    StaffDepartment = "Database Management",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 12,
                    StaffFirstName = "Darren",
                    StaffLastName = "Ong",
                    StaffEmail = "darren.ong@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Business Analyst",
                    StaffAddress = "Business Street",
                    StaffHPNum = "98889900",
                    StaffDepartment = "Business Analysis",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 13,
                    StaffFirstName = "Samantha",
                    StaffLastName = "Tan",
                    StaffEmail = "samantha.tan@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Technical Support Specialist",
                    StaffAddress = "Tech Support Lane",
                    StaffHPNum = "99990011",
                    StaffDepartment = "Technical Support",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 14,
                    StaffFirstName = "Gary",
                    StaffLastName = "Koh",
                    StaffEmail = "gary.koh@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "IT Manager",
                    StaffAddress = "IT Management Street",
                    StaffHPNum = "91110022",
                    StaffDepartment = "IT Management",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 15,
                    StaffFirstName = "Andrew",
                    StaffLastName = "Lau",
                    StaffEmail = "andrew.lau@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Software Tester",
                    StaffAddress = "Testing Street",
                    StaffHPNum = "91112233",
                    StaffDepartment = "Quality Assurance",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 16,
                    StaffFirstName = "Rachel",
                    StaffLastName = "Lim",
                    StaffEmail = "rachel.lim@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Network Engineer",
                    StaffAddress = "Networking Lane",
                    StaffHPNum = "92223344",
                    StaffDepartment = "Network Engineering",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 17,
                    StaffFirstName = "Ethan",
                    StaffLastName = "Neo",
                    StaffEmail = "ethan.neo@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Systems Architect",
                    StaffAddress = "Architecture Avenue",
                    StaffHPNum = "93334455",
                    StaffDepartment = "System Architecture",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 18,
                    StaffFirstName = "Sophia",
                    StaffLastName = "Chong",
                    StaffEmail = "sophia.chong@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Database Analyst",
                    StaffAddress = "Data Analysis Street",
                    StaffHPNum = "94445566",
                    StaffDepartment = "Database Analysis",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 19,
                    StaffFirstName = "Nathan",
                    StaffLastName = "Loh",
                    StaffEmail = "nathan.loh@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Project Coordinator",
                    StaffAddress = "Project Coordination Lane",
                    StaffHPNum = "95556677",
                    StaffDepartment = "Project Coordination",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 20,
                    StaffFirstName = "Isabel",
                    StaffLastName = "Koh",
                    StaffEmail = "isabel.koh@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "UI/UX Designer",
                    StaffAddress = "Design Studio",
                    StaffHPNum = "96667788",
                    StaffDepartment = "Design Team",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 21,
                    StaffFirstName = "Brian",
                    StaffLastName = "Ong",
                    StaffEmail = "brian.ong@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Database Administrator",
                    StaffAddress = "Data Center Lane",
                    StaffHPNum = "97778899",
                    StaffDepartment = "Database Management",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 22,
                    StaffFirstName = "Catherine",
                    StaffLastName = "Yap",
                    StaffEmail = "catherine.yap@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Business Intelligence Analyst",
                    StaffAddress = "Business Intelligence Street",
                    StaffHPNum = "98889900",
                    StaffDepartment = "Business Intelligence",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 23,
                    StaffFirstName = "Oscar",
                    StaffLastName = "Gan",
                    StaffEmail = "oscar.gan@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "Technical Support Engineer",
                    StaffAddress = "Tech Support Lane",
                    StaffHPNum = "99990011",
                    StaffDepartment = "Technical Support",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 24,
                    StaffFirstName = "Hannah",
                    StaffLastName = "Chua",
                    StaffEmail = "hannah.chua@example.com",
                    StaffHireDate = DateTime.Now,
                    StaffPosition = "IT Director",
                    StaffAddress = "IT Leadership Street",
                    StaffHPNum = "91110022",
                    StaffDepartment = "IT Leadership",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
