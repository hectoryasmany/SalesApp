using Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace SaleAppWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<City> Cities { get; set; }

        
    }

}

