using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Smartstore.ProductViewTracker.Domain
{
   
        public class ProductViewMap : IEntityTypeConfiguration<ProductView>
        {
            public void Configure(EntityTypeBuilder<ProductView> builder)
            {
                builder.ToTable("ProductView");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.ProductId).IsRequired();
                builder.Property(x => x.ViewCount).IsRequired();
                builder.Property(x => x.LastViewedOn).IsRequired();
            }
        }
    
}
