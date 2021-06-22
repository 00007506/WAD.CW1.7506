using Microsoft.EntityFrameworkCore;
using System;
using WAD.WebApp._7506.DAL.DTO;

namespace WAD.WebApp._7506.DAL
{
    public class CarRentDbContext : DbContext
    {
        public CarRentDbContext(DbContextOptions<CarRentDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Employee> Employee { get; set; }

        public virtual DbSet<Branch> Branch { get; set; }
    }
}
