using Microsoft.EntityFrameworkCore;
using OpportunIT_Platform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunIT_Platform.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Login> Login { get; set; }

    }

}
