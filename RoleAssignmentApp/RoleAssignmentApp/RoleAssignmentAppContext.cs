using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAssignmentApp
{
    public class RoleAssignmentAppContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=RoleAssignmentAppDB;Trusted_Connection=true");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
