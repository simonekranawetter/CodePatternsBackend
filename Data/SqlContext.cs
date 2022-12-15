using CodePatternsBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodePatternsBackend.Data
{ //LISKOV SUBSTITUTION PRINCIPLE
  //Parent class should be easiy substituted with their child class, this was the easiest way to show this here. 
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        public DbSet<ProductEntity> Products => Set<ProductEntity>();
        public DbSet<ProductCategoryEntity> ProductCategories => Set<ProductCategoryEntity>();
    }
}
