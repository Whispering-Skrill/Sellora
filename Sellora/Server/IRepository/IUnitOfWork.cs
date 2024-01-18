using Sellora.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sellora.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
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