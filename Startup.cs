using Microsoft.Extensions.DependencyInjection;
using Smartstore.Engine;
using Smartstore.Engine.Builders;
using Smartstore.ProductViewTracker.Services;
using Microsoft.EntityFrameworkCore;
using Smartstore.Data;
using Smartstore.Data.Providers;
using Smartstore.Core.Data;
using System;
using Smartstore.ProductViewTracker.Domain;



namespace Smartstore.ProductViewTracker
{
    public class Startup : StarterBase
    {
        public override void ConfigureServices(IServiceCollection services, IApplicationContext appContext)
        {
            services.AddTransient<IDbContextConfigurationSource<SmartDbContext>, SmartDbContextConfigurer>();
        }

        private class SmartDbContextConfigurer : IDbContextConfigurationSource<SmartDbContext>
        {
            public void Configure(IServiceProvider services, DbContextOptionsBuilder builder)
            {
                builder.UseDbFactory(b => b.AddModelAssembly(GetType().Assembly));
            }
        }
    }
}