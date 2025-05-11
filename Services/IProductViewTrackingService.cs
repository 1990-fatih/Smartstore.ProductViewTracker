using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartstore.ProductViewTracker.Services
{
    public interface IProductViewTrackingService
    {
        Task<int> GetViewCountAsync(int productId);
        Task RecordViewAsync(int productId);
    }
}
