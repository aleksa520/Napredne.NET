using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatabaseEFCore
{
    public class V1Context : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EmployeeDB;Trusted_Connection=True;");
        }
    }
}
