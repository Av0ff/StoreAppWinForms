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
	internal class AcceptedsConfiguration : IEntityTypeConfiguration<Accepted>
	{
		public void Configure(EntityTypeBuilder<Accepted> builder)
		{
			builder.HasKey(a => a.Id);
			builder.HasIndex(a => a.Id).IsUnique();
			builder.HasOne(a => a.Product).WithOne();
		}
	}
}
