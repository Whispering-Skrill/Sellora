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
        private readonly ApplicationDbContext _context;
        private IGenericRepository<User> _users;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Item> _items;
        private IGenericRepository<Report> _reports;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<SwapTransaction> _swaptransactions;
        private IGenericRepository<SaleTransaction> _saletransactions;
        private IGenericRepository<Category> _categories;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<User> Users
            => _users ??= new GenericRepository<User>(_context);
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

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

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