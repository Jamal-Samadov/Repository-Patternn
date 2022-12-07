using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using University.DAL.Entities;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace University.DAL.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public System.Data.Entity.DbSet<Student> Students { get; set; }
    }
}
