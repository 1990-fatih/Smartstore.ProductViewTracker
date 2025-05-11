using System;
using Smartstore.Domain;

namespace Smartstore.ProductViewTracker.Domain
{
    public class ProductViewRecord : BaseEntity
    {
        public int ProductId { get; set; }
        public DateTime LastViewedOn { get; set; }
        public int ViewCount { get; set; }
    }
}