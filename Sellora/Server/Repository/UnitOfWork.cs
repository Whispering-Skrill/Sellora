using Sellora.Server.Data;
using Sellora.Server.IRepository;
using Sellora.Server.Models;
using Sellora.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Sellora.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        // DbContext instance for database operations
        private readonly ApplicationDbContext _context;

        // Repositories for different entities
        private IGenericRepository<AppUser> _appusers;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Item> _items;
        private IGenericRepository<Report> _reports;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<SwapTransaction> _swaptransactions;
        private IGenericRepository<SaleTransaction> _saletransactions;
        private IGenericRepository<Category> _categories;

        // UserManager for working with users
        private UserManager<ApplicationUser> _userManager;

        // Constructor to initialize the unit of work with the DbContext and UserManager
        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Properties representing individual repositories for different entities
        public IGenericRepository<AppUser> AppUsers
            => _appusers ??= new GenericRepository<AppUser>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<Item> Items
            => _items ??= new GenericRepository<Item>(_context);
        public IGenericRepository<Report> Reports
            => _reports ??= new GenericRepository<Report>(_context);
        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<SwapTransaction> SwapTransactions
            => _swaptransactions ??= new GenericRepository<SwapTransaction>(_context);
        public IGenericRepository<SaleTransaction> SaleTransactions
            => _saletransactions ??= new GenericRepository<SaleTransaction>(_context);
        public IGenericRepository<Category> Categories
            => _categories ??= new GenericRepository<Category>(_context);

        // Method to release resources when the unit of work is disposed
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        // Method to save changes to the underlying data store
        public async Task Save(HttpContext httpContext)
        {
            // For Default Attribute/Entity/Data Creation
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            // Updating date and user information for each modified or added entity
            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}