using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Persistence.EntityTypeConfigurations
{
	public class ProductsConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(product => product.Id);
			builder.HasIndex(product => product.Id).IsUnique();
			builder.HasOne(p => p.Status)
				.WithMany(s => s.Products).OnDelete(DeleteBehavior.Cascade);
		}
	}
}
