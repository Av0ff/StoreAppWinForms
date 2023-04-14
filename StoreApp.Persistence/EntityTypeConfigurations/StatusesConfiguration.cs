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
	internal class StatusesConfiguration : IEntityTypeConfiguration<Status>
	{
		public void Configure(EntityTypeBuilder<Status> builder)
		{
			builder.HasKey(s => s.Name);
			builder.HasIndex(s => s.Name).IsUnique();
			builder.HasMany(s => s.Products)
				.WithOne(p => p.Status);
			builder.HasData(
				new Status { Name = "Accepted" },
				new Status { Name = "OnStore"},
				new Status { Name = "Sold"}
				);
		}
	}
}
