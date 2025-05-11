using Microsoft.EntityFrameworkCore;
using Smartstore.Data;

public class ProductViewTrackingDbContext : DbContextBase
{
    public ProductViewTrackingDbContext(DbContextOptions options) : base(options) { }

    public DbSet<ProductView> ProductViews { get; set; }
}