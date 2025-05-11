using Microsoft.EntityFrameworkCore;
using Smartstore.ProductViewTracker.Domain;
using Smartstore.Data;
using Smartstore.Core.Data;

namespace Smartstore.ProductViewTracker.Extensions
{
    public static class SmartDbContextExtensions
    {
        public static DbSet<ProductView> ProductViews(this SmartDbContext db)
            => db.Set<ProductView>();
    }
}
