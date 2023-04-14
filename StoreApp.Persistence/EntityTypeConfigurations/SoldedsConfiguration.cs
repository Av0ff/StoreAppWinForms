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
	internal class SoldedsConfiguration : IEntityTypeConfiguration<Solded>
	{
		public void Configure(EntityTypeBuilder<Solded> builder)
		{
			builder.HasKey(so => so.Id);
			builder.HasIndex(so => so.Id).IsUnique();
			builder.HasOne(so => so.Product).WithOne();
		}
	}
}
