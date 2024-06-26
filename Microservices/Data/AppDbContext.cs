﻿using Microservices.Models;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
                        
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
