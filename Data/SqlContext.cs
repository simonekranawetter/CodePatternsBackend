using CodePatternsBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodePatternsBackend.Data
{ //todo add Liskov comment
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        public DbSet<ProductEntity> Products => Set<ProductEntity>();
        public DbSet<ProductCategoryEntity> ProductCategories => Set<ProductCategoryEntity>();
    }
}
