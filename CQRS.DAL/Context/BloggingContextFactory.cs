using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.DAL.Context
{
    public class CQRSContextFactory : IDesignTimeDbContextFactory<CQRSContext>
    {
        public CQRSContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CQRSContext>();
            optionsBuilder.UseSqlServer(@"Server=.; initial catalog=CQRS;integrated security=true");

            return new CQRSContext(optionsBuilder.Options);
        }
    }
}
