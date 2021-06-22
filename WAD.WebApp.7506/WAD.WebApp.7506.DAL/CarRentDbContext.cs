using Microsoft.EntityFrameworkCore;
using System;
using WAD.WebApp._7506.DAL.DTO;

namespace WAD.WebApp._7506.DAL
{
    public class CarRentDbContext : DbContext
    {
        public CarRentDbContext()
        {

        }
        public CarRentDbContext(DbContextOptions<CarRentDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("DataSource=CarRent.db");

        public virtual DbSet<Employee> Employee { get; set; }

        public virtual DbSet<Branch> Branch { get; set; }
    }
}
