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
                UserName = "SeoCoolSeoYeong",
                UserFirstName = "Seo",
                UserLastName = "Yeong",
                UserEmail = "sy123@gmail.com",
                UserPassword = hasher.HashPassword(null, "P@ssword1"),
                UserHPNum = "88123123",
                UserRegDate = DateTime.Now,
                UserDescription = "Passionate about all things digital and SEO wizardry 🚀 | Helping businesses climb the search engine ranks 📈 | Coffee enthusiast ☕ | Explorer of new tech and trends 🌐 | #SEOExpert #DigitalMarketing",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 2,
                UserName = "TT_4Me",
                UserFirstName = "Tina",
                UserLastName = "Tan",
                UserEmail = "tt123@gmail.com",
                UserPassword = hasher.HashPassword(null, "P@ssword2"),
                UserHPNum = "88445566",
                UserRegDate = DateTime.Now,
                UserDescription = "Creative soul navigating the digital realm 🌟 | Graphic designer by day, dreamer by night ✨ | Turning ideas into visual wonders 🎨 | Coffee addict ☕ | Embracing the beauty of design and storytelling 🖌️ | #GraphicDesigner #Dreamer",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 3,
                UserName = "Kay_today",
                UserFirstName = "Kaynan",
                UserLastName = "Loh",
                UserEmail = "kl23@gmail.com",
                UserPassword = hasher.HashPassword(null, "P@ssword5"),
                UserHPNum = "85445666",
                UserRegDate = DateTime.Now,
                UserDescription = "Adventurous spirit with a flair for tech and innovation 🚀 | Coding maestro by day, gaming wizard by night 🎮 | Constantly exploring the digital frontier 💻 | Fuelled by curiosity and a love for challenges 🌐 | Living life one line of code at a time! #TechExplorer #GamingEnthusiast",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 4,
                UserName = "AdventureCoder",
                UserFirstName = "Alex",
                UserLastName = "Smith",
                UserEmail = "alex.smith@example.com",
                UserPassword = hasher.HashPassword(null, "SecureP@ss123"),
                UserHPNum = "9876543210",
                UserRegDate = DateTime.Now,
                UserDescription = "Passionate about coding adventures and tech wonders 🌟 | Coffee-fueled developer by day, gaming enthusiast by night 🎮 | Embracing challenges and turning ideas into reality 💡 | #CodeExplorer #TechEnthusiast",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 5,
                UserName = "DigitalNomad21",
                UserFirstName = "Emma",
                UserLastName = "Johnson",
                UserEmail = "emma.johnson@example.com",
                UserPassword = hasher.HashPassword(null, "NomadLife!23"),
                UserHPNum = "8765432109",
                UserRegDate = DateTime.Now,
                UserDescription = "Digital nomad exploring the virtual realms 🌍 | Coding on-the-go and crafting unique digital experiences ✨ | Passionate about connecting through technology 🚀 | #DigitalNomad #CodeExplorer",
                UserLastOnline = DateTime.Now
            }
            );
        }
    }
}
