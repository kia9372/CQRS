using CQRS.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.DAL.Context
{
    public class CQRSContext : DbContext
    {
        public CQRSContext(DbContextOptions<CQRSContext> options)
            : base(options)
        { }
        public DbSet<User> Users { get; set; }
    }
}
