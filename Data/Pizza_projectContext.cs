using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizza_project.Models;

    public class Pizza_projectContext : IdentityDbContext
    {
        public Pizza_projectContext (DbContextOptions<Pizza_projectContext> options)
            : base(options)
        {
        }

        public DbSet<Pizza_project.Models.Pizza> Pizza { get; set; } = default!;

        public DbSet<Pizza_project.Models.Order> Order { get; set; }

        public DbSet<Pizza_project.Models.Status> Status { get; set; }
    }
