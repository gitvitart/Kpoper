using Kpoper.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kpoper.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Idol> Idols => Set<Idol>();
    }
}
