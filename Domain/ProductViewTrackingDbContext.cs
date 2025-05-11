using Microsoft.EntityFrameworkCore;
using Smartstore.ProductViewTracker.Domain;

public class ProductViewTrackingDbContext : DbContext
{
    public ProductViewTrackingDbContext(DbContextOptions<ProductViewTrackingDbContext> options)
        : base(options) { }

    public DbSet<ProductViewRecord> ProductViewRecords { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductViewRecord>().ToTable("ProductViewRecord");
        base.OnModelCreating(modelBuilder);
    }
}