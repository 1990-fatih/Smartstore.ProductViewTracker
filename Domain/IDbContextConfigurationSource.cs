using Microsoft.EntityFrameworkCore;
using Smartstore.Data;
using System;
using Smartstore.Data.Providers;

public class ProductViewTrackingDbContextConfigurer : IDbContextConfigurationSource<ProductViewTrackingDbContext>
{
    public void Configure(IServiceProvider services, DbContextOptionsBuilder builder)
    {
        builder.UseDbFactory(options =>
        {
            // Bu assembly'deki modelleri kullan
            options.AddModelAssembly(typeof(ProductViewTrackingDbContextConfigurer).Assembly);
        });
    }
}
