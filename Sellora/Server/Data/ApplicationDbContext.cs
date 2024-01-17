using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sellora.Server.Configurations.Entities;
using Sellora.Server.Models;
using Sellora.Shared.Domain;

namespace Sellora.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SaleTransaction> SaleTransactions { get; set; }
        public DbSet<SwapTransaction> SwapTransactions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new StaffSeedConfiguration());

            builder.ApplyConfiguration(new CategorySeedConfiguration());
        }
    }
}
