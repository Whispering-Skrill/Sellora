using CarRentalManagement.Server.Configurations.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sellora.Server.Configurations.Entities;
using Sellora.Server.Models;
using Sellora.Shared.Domain;
using System.Reflection.Emit;

namespace Sellora.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        // DbSet properties for various entities in the application
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SaleTransaction> SaleTransactions { get; set; }
        public DbSet<SwapTransaction> SwapTransactions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Method for configuring the model using Fluent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Call the base class method to ensure base configurations are applied
            base.OnModelCreating(builder);

            // Applying seed configurations for specific entities

            builder.ApplyConfiguration(new StaffSeedConfiguration());

            builder.ApplyConfiguration(new ItemSeedConfiguration());

            builder.ApplyConfiguration(new CategorySeedConfiguration());

            builder.ApplyConfiguration(new ApplicationUserSeedConfiguration());

            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

            builder.ApplyConfiguration(new SwapSeedConfiguration());

            builder.ApplyConfiguration(new ReviewSeedConfiguration());

            builder.ApplyConfiguration(new ReportSeedConfiguration());

            // Configure SwapTransaction relationships to Not Cascade on Delete
            builder.Entity<SwapTransaction>()
                .HasOne(st => st.AppUser1)
                .WithMany()
                .HasForeignKey(st => st.AppUser1Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SwapTransaction>()
                .HasOne(st => st.SwapItem1)
                .WithMany()
                .HasForeignKey(st => st.SwapItem1Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SwapTransaction>()
                .HasOne(st => st.AppUser2)
                .WithMany()
                .HasForeignKey(st => st.AppUser2Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SwapTransaction>()
                .HasOne(st => st.SwapItem2)
                .WithMany()
                .HasForeignKey(st => st.SwapItem2Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
