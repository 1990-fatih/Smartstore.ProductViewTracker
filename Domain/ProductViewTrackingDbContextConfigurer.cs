using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Smartstore.Core.Data;
using Smartstore.Data.Providers;
using Smartstore.Data;

namespace Smartstore.ProductViewTracker.Domain
{
    public class ProductViewTrackingDbContextConfigurer : IDbContextConfigurationSource<ProductViewTrackingDbContext>
    {
        public void Configure(IServiceProvider services, DbContextOptionsBuilder builder)
        {
            builder.UseDbFactory(b =>
            {
                b.AddModelAssembly(typeof(ProductViewTrackingDbContext).Assembly);
            });
        }
    }
}
