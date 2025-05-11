using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Smartstore.ProductViewTracker.Domain;
using Smartstore.ProductViewTracker.Services;

public class ProductViewTrackingService : IProductViewTrackingService
{
    private readonly ProductViewTrackingDbContext _db;

    public ProductViewTrackingService(ProductViewTrackingDbContext db)
    {
        _db = db;
    }

    public async Task RecordViewAsync(int productId)
    {
        var record = await _db.ProductViews.FirstOrDefaultAsync(x => x.ProductId == productId);

        if (record == null)
        {
            record = new ProductView
            {
                ProductId = productId,
                LastViewedOn = DateTime.UtcNow,
                ViewCount = 1
            };
            await _db.ProductViews.AddAsync(record);
        }
        else
        {
            record.LastViewedOn = DateTime.UtcNow;
            record.ViewCount++;
        }

        await _db.SaveChangesAsync();
    }

    public async Task<int> GetViewCountAsync(int productId)
    {
        var record = await _db.ProductViews.FirstOrDefaultAsync(x => x.ProductId == productId);
        return record?.ViewCount ?? 0;
    }
}
