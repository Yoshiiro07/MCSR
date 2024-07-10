using Catalog.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Catalog.API.Infrastructure
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }

        public DbSet<CatalogItem> CatalogItem { get; set; }
    }

    //public class CatalogContextDesignFactory : IDesignTimeDbContextFactory<CatalogContext>
    //{
    //    public CatalogContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<CatalogContext>()
    //            .UseSqlite("Server=.;Initial Catalog=Microsoft.eShopOnContainers.Services.CatalogDb;Integrated Security=true");

    //        return new CatalogContext(optionsBuilder.Options);
    //    }
    //}
}
