using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Smartstore.Data;
using Smartstore.ProductViewTracker.Domain;

namespace Smartstore.ProductViewTracker.Domain
{
    public class ProductViewTrackingDbContext : DbContext
    {
        public ProductViewTrackingDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ProductView> ProductViews { get; set; }
    }
}