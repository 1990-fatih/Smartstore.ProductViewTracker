using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace Smartstore.ProductViewTracker.Domain

{
    [Table("ProductView")]
    [Index(nameof(ProductId), Name = "IX_ProductView_ProductId")]
    public class ProductViewRecord : BaseEntity
    {
        public int ProductId { get; set; }
        public DateTime LastViewedOn { get; set; }
        public int ViewCount { get; set; }
    }
}