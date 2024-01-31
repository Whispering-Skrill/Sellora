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
                UserHPNum = "98765210",
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
                UserHPNum = "87654109",
                UserRegDate = DateTime.Now,
                UserDescription = "Digital nomad exploring the virtual realms 🌍 | Coding on-the-go and crafting unique digital experiences ✨ | Passionate about connecting through technology 🚀 | #DigitalNomad #CodeExplorer",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 6,
                UserName = "TechEnthusiast",
                UserFirstName = "Alex",
                UserLastName = "Smith",
                UserEmail = "alex.smith@example.com",
                UserPassword = hasher.HashPassword(null, "TechSwap@123"),
                UserHPNum = "98763210",
                UserRegDate = DateTime.Now,
                UserDescription = "Tech enthusiast looking to swap and sell gadgets 📱💻 | Always up for the latest tech trends and innovations 🚀 | Let's connect and trade! #TechSwap #GadgetLover",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 7,
                UserName = "Fashionista23",
                UserFirstName = "Sophie",
                UserLastName = "Miller",
                UserEmail = "sophie.miller@example.com",
                UserPassword = hasher.HashPassword(null, "ChicStyle@45"),
                UserHPNum = "87698765",
                UserRegDate = DateTime.Now,
                UserDescription = "Fashionista with a passion for style and trends 👗👠 | Closet cleanout and trendy swaps | Let's trade fashion finds! #FashionSwap #StyleExplorer",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 8,
                UserName = "GamingPro99",
                UserFirstName = "Ryan",
                UserLastName = "Clark",
                UserEmail = "ryan.clark@example.com",
                UserPassword = hasher.HashPassword(null, "GameOn!789"),
                UserHPNum = "90345678",
                UserRegDate = DateTime.Now,
                UserDescription = "Gaming pro seeking to trade and sell video games 🎮 | From classics to the latest releases | Let's level up together! #GameSwap #GamerLife",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 9,
                UserName = "BookWorm89",
                UserFirstName = "Olivia",
                UserLastName = "Taylor",
                UserEmail = "olivia.taylor@example.com",
                UserPassword = hasher.HashPassword(null, "Read4Swap!"),
                UserHPNum = "87651256",
                UserRegDate = DateTime.Now,
                UserDescription = "Bookworm passionate about literature 📚 | Looking to swap and sell books of all genres | Let's share the joy of reading! #BookSwap #LiteraryExplorer",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 10,
                UserName = "OutdoorAdventurer",
                UserFirstName = "Jake",
                UserLastName = "Anderson",
                UserEmail = "jake.anderson@example.com",
                UserPassword = hasher.HashPassword(null, "Nature123!"),
                UserHPNum = "90129854",
                UserRegDate = DateTime.Now,
                UserDescription = "Outdoor enthusiast and adventurer 🏞️ | Swapping and selling outdoor gear and equipment | Let's explore the world together! #AdventureSwap #NatureExplorer",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 11,
                UserName = "HomeDecorGuru",
                UserFirstName = "Mia",
                UserLastName = "Ramirez",
                UserEmail = "mia.ramirez@example.com",
                UserPassword = hasher.HashPassword(null, "DecorateMe!"),
                UserHPNum = "87652012",
                UserRegDate = DateTime.Now,
                UserDescription = "Home decor enthusiast with a flair for design 🏡 | Swapping and selling unique decor pieces | Let's create stylish living spaces! #DecorSwap #HomeDesign",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 12,
                UserName = "FitnessFreak2024",
                UserFirstName = "Brandon",
                UserLastName = "Harris",
                UserEmail = "brandon.harris@example.com",
                UserPassword = hasher.HashPassword(null, "FitLife@2024"),
                UserHPNum = "90125432",
                UserRegDate = DateTime.Now,
                UserDescription = "Fitness enthusiast on a journey to a healthier life 💪 | Swapping and selling workout gear and accessories | Let's achieve our fitness goals together! #FitnessSwap #HealthyLiving",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 13,
                UserName = "ArtisticExplorer",
                UserFirstName = "Eva",
                UserLastName = "Chen",
                UserEmail = "eva.chen@example.com",
                UserPassword = hasher.HashPassword(null, "ArtisticSoul!"),
                UserHPNum = "87655678",
                UserRegDate = DateTime.Now,
                UserDescription = "Art lover and creative soul 🎨 | Swapping and selling unique artworks and handmade crafts | Let's appreciate and share the beauty of art! #ArtSwap #CreativeSpirit",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 14,
                UserName = "VintageCollector",
                UserFirstName = "Lillian",
                UserLastName = "Baker",
                UserEmail = "lillian.baker@example.com",
                UserPassword = hasher.HashPassword(null, "RetroLove!"),
                UserHPNum = "90128543",
                UserRegDate = DateTime.Now,
                UserDescription = "Passionate vintage collector and enthusiast 🕰️ | Swapping and selling unique retro finds | Let's cherish the charm of the past! #VintageSwap #RetroCollector",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 15,
                UserName = "PetLover21",
                UserFirstName = "David",
                UserLastName = "Nguyen",
                UserEmail = "david.nguyen@example.com",
                UserPassword = hasher.HashPassword(null, "PetCare!2024"),
                UserHPNum = "87656789",
                UserRegDate = DateTime.Now,
                UserDescription = "Animal lover and pet enthusiast 🐾 | Swapping and selling pet accessories and supplies | Let's pamper our furry friends together! #PetSwap #AnimalCare",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 16,
                UserName = "FilmBuff87",
                UserFirstName = "Rachel",
                UserLastName = "Mitchell",
                UserEmail = "rachel.mitchell@example.com",
                UserPassword = hasher.HashPassword(null, "Cinephile@87"),
                UserHPNum = "9012654321",
                UserRegDate = DateTime.Now,
                UserDescription = "Film buff and cinephile 🎬 | Swapping and selling DVDs, Blu-rays, and movie memorabilia | Let's share our favorite cinematic experiences! #FilmSwap #Cinephilia",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 17,
                UserName = "MusicMaestro",
                UserFirstName = "Daniel",
                UserLastName = "Garcia",
                UserEmail = "daniel.garcia@example.com",
                UserPassword = hasher.HashPassword(null, "MusicMagic!"),
                UserHPNum = "8765567890",
                UserRegDate = DateTime.Now,
                UserDescription = "Music enthusiast and maestro 🎶 | Swapping and selling vinyl records, instruments, and music accessories | Let's create a symphony of sounds! #MusicSwap #MelodyMaker",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 18,
                UserName = "DIYCraftsman",
                UserFirstName = "Ava",
                UserLastName = "Turner",
                UserEmail = "ava.turner@example.com",
                UserPassword = hasher.HashPassword(null, "CraftyMind!"),
                UserHPNum = "9012543210",
                UserRegDate = DateTime.Now,
                UserDescription = "DIY crafts enthusiast and artisan ✂️ | Swapping and selling handmade crafts and DIY supplies | Let's unleash our creative spirits! #CraftSwap #DIYArtisan",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 19,
                UserName = "FoodieExplorer",
                UserFirstName = "Isaac",
                UserLastName = "Evans",
                UserEmail = "isaac.evans@example.com",
                UserPassword = hasher.HashPassword(null, "FoodJourney!"),
                UserHPNum = "8765678901",
                UserRegDate = DateTime.Now,
                UserDescription = "Food lover and culinary adventurer 🍲 | Swapping and selling gourmet ingredients and kitchenware | Let's savor the flavors of the world! #FoodSwap #CulinaryExplorer",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 20,
                UserName = "FitnessFanatic",
                UserFirstName = "Lily",
                UserLastName = "Carter",
                UserEmail = "lily.carter@example.com",
                UserPassword = hasher.HashPassword(null, "FitFreak@2024"),
                UserHPNum = "9012432109",
                UserRegDate = DateTime.Now,
                UserDescription = "Fitness fanatic committed to a healthy lifestyle 💪 | Swapping and selling workout plans and fitness gear | Let's crush our fitness goals together! #FitnessSwap #HealthJunkie",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 21,
                UserName = "TechGeek2024",
                UserFirstName = "Logan",
                UserLastName = "Thompson",
                UserEmail = "logan.thompson@example.com",
                UserPassword = hasher.HashPassword(null, "GeekLife@2024"),
                UserHPNum = "8765789012",
                UserRegDate = DateTime.Now,
                UserDescription = "Tech geek exploring the latest gadgets and innovations 🤖 | Swapping and selling tech accessories and devices | Let's embrace the digital revolution! #TechSwap #GadgetGeek",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 22,
                UserName = "PlantEnthusiast",
                UserFirstName = "Sophia",
                UserLastName = "Williams",
                UserEmail = "sophia.williams@example.com",
                UserPassword = hasher.HashPassword(null, "GreenThumb!"),
                UserHPNum = "9012321098",
                UserRegDate = DateTime.Now,
                UserDescription = "Plant enthusiast with a green thumb 🌿 | Swapping and selling unique plants and gardening tools | Let's cultivate our love for nature! #PlantSwap #GreenLiving",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 23,
                UserName = "TravelExplorer",
                UserFirstName = "Leo",
                UserLastName = "Hernandez",
                UserEmail = "leo.hernandez@example.com",
                UserPassword = hasher.HashPassword(null, "Wanderlust@123"),
                UserHPNum = "8765890123",
                UserRegDate = DateTime.Now,
                UserDescription = "Travel enthusiast with a passion for exploration ✈️ | Swapping and selling travel gear and accessories | Let's embark on new adventures! #TravelSwap #Wanderlust",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 24,
                UserName = "BoardGameMaster",
                UserFirstName = "Sophie",
                UserLastName = "Turner",
                UserEmail = "sophie.turner@example.com",
                UserPassword = hasher.HashPassword(null, "GameNight!"),
                UserHPNum = "9012210987",
                UserRegDate = DateTime.Now,
                UserDescription = "Board game enthusiast and strategist 🎲 | Swapping and selling classic and modern board games | Let's have fun game nights! #GameSwap #BoardGameMaster",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 25,
                UserName = "FashionForward",
                UserFirstName = "Mason",
                UserLastName = "Ward",
                UserEmail = "mason.ward@example.com",
                UserPassword = hasher.HashPassword(null, "StyleIcon@2024"),
                UserHPNum = "8765987654",
                UserRegDate = DateTime.Now,
                UserDescription = "Fashion-forward individual with an eye for style 👗🕶️ | Swapping and selling trendy fashion items | Let's stay ahead in the fashion game! #FashionSwap #StyleInnovator",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 26,
                UserName = "TechInnovator",
                UserFirstName = "Zoe",
                UserLastName = "Barnes",
                UserEmail = "zoe.barnes@example.com",
                UserPassword = hasher.HashPassword(null, "InnovateTech!"),
                UserHPNum = "9012109876",
                UserRegDate = DateTime.Now,
                UserDescription = "Tech innovator and early adopter of cutting-edge tech 🚀 | Swapping and selling innovative gadgets | Let's redefine the digital experience! #TechSwap #InnovationGeek",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 27,
                UserName = "MusicExplorer",
                UserFirstName = "Natalie",
                UserLastName = "Johnson",
                UserEmail = "natalie.johnson@example.com",
                UserPassword = hasher.HashPassword(null, "ExploreSounds!"),
                UserHPNum = "8765098765",
                UserRegDate = DateTime.Now,
                UserDescription = "Music explorer with a diverse taste in melodies 🎵 | Swapping and selling rare music albums and instruments | Let's discover new rhythms! #MusicSwap #SoundExplorer",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 28,
                UserName = "ArtisanCrafts",
                UserFirstName = "Elijah",
                UserLastName = "Fisher",
                UserEmail = "elijah.fisher@example.com",
                UserPassword = hasher.HashPassword(null, "CraftedArt@123"),
                UserHPNum = "9012987654",
                UserRegDate = DateTime.Now,
                UserDescription = "Artisan crafting unique handmade artworks and crafts 🎨 | Swapping and selling one-of-a-kind creations | Let's appreciate the beauty of craftsmanship! #ArtisanSwap #CraftedBeauty",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 29,
                UserName = "CulinaryConnoisseur",
                UserFirstName = "Hannah",
                UserLastName = "Clark",
                UserEmail = "hannah.clark@example.com",
                UserPassword = hasher.HashPassword(null, "CulinaryDelight!"),
                UserHPNum = "8765234012",
                UserRegDate = DateTime.Now,
                UserDescription = "Culinary connoisseur and food enthusiast 🍳 | Swapping and selling gourmet ingredients and kitchen tools | Let's create delicious masterpieces! #CulinarySwap #FoodieDelight",
                UserLastOnline = DateTime.Now
            },
            new AppUser
            {
                Id = 30,
                UserName = "BoardGameEnthusiast",
                UserFirstName = "Caleb",
                UserLastName = "Roberts",
                UserEmail = "caleb.roberts@example.com",
                UserPassword = hasher.HashPassword(null, "GameNight@2024"),
                UserHPNum = "9012765432",
                UserRegDate = DateTime.Now,
                UserDescription = "Board game enthusiast organizing epic game nights 🎲 | Swapping and selling classic and strategy board games | Let's roll the dice and have fun! #BoardGameSwap #GameNightOrganizer",
                UserLastOnline = DateTime.Now
            }
            );
        }
    }
}
