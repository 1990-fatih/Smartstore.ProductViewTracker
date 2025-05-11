using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Smartstore.Data;
using Smartstore.Data.Providers;

namespace Smartstore.ProductViewTracker.Domain
{
    public class ProductViewTrackingDbContextConfigurer : IDbContextConfigurationSource<ProductViewTrackingDbContext>
    {
        public void Configure(IServiceProvider services, DbContextOptionsBuilder builder)
        {
            builder.UseDbFactory(factory =>
            {
                factory.AddModelAssembly(typeof(ProductViewTrackingDbContext).Assembly);
            });
        }
    }
}