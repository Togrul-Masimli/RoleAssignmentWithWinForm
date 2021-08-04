using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RoleAssignmentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=RoleAssignmentDB;Trusted_Connection=true");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Editor> Editors { get; set; }

    }
}
