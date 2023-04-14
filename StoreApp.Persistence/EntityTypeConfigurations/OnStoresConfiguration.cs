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
	internal class OnStoresConfiguration : IEntityTypeConfiguration<OnStore>
	{
		public void Configure(EntityTypeBuilder<OnStore> builder)
		{
			builder.HasKey(os => os.Id);
			builder.HasIndex(os => os.Id).IsUnique();
			builder.HasOne(os => os.Product).WithOne();
		}
	}
}
