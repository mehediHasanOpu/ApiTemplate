using Core.Models;
using Core.Models.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public DbSet<Categories> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            Assembly assemblyWithConfigurations = GetType().Assembly;
            builder.ApplyConfigurationsFromAssembly(assemblyWithConfigurations);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            
        }
    }
}
