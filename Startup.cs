using Microsoft.Extensions.DependencyInjection;
using Smartstore.Engine;
using Smartstore.Engine.Builders;
using Smartstore.ProductViewTracker.Services;
using Microsoft.EntityFrameworkCore;
using Smartstore.Data;
using Smartstore.Data.Providers;



namespace Smartstore.ProductViewTracker
{
    public class Startup : StarterBase
    {
        public override void ConfigureServices(IServiceCollection services, IApplicationContext appContext)
        {
            // Doğru context configurator'ı ekliyoruz
            services.AddTransient<IDbContextConfigurationSource<ProductViewTrackingDbContext>, ProductViewTrackingDbContextConfigurer>();

            // Servis kaydı
            services.AddScoped<IProductViewTrackingService, ProductViewTrackingService>();
        }
    }
}