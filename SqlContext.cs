using CodePatternsBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodePatternsBackend
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        public DbSet<ProductEntity> Products => Set<ProductEntity>();
    }
}
