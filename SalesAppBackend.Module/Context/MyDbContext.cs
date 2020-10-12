using Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppBackend.Module.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(string connectionString) : base(connectionString) { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
