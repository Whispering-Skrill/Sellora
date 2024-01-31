using Sellora.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sellora.Server.IRepository
{
    // Interface representing a unit of work for managing multiple repositories
    public interface IUnitOfWork : IDisposable
    {
        // Saves changes to the underlying data store and ensures any pending changes are completed
        Task Save(HttpContext httpContext);

        // Properties representing individual repositories for different entities
        IGenericRepository<AppUser> AppUsers { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Item> Items { get; }
        IGenericRepository<Report> Reports { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<SwapTransaction> SwapTransactions { get; }
        IGenericRepository<SaleTransaction> SaleTransactions { get; }
        IGenericRepository<Category> Categories { get; }
    }
}     