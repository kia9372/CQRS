using CQRS.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.DAL.Context
{
    public class CQRSContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
