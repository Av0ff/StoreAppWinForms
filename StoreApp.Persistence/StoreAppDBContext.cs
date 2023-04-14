using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StoreApp.Data;
using StoreApp.Persistence.EntityTypeConfigurations;
using StoreApp.Persistence.IDBContext;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Persistence
{
	public class StoreAppDBContext : DbContext, IStoreAppDBContext
	{
		public static DbContextOptionsBuilder Options
		{
			get
			{
				if (_options == null)
				{
					_options = new DbContextOptionsBuilder();
					_options.UseSqlServer(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
				}

				return _options;
			}
		}
		private static DbContextOptionsBuilder _options;

		public StoreAppDBContext() : base(Options.Options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Status> Statuses { get; set; }
		public DbSet<Accepted> Accepteds { get; set; }
		public DbSet<OnStore> OnStores { get; set; }
		public DbSet<Solded> Soldeds { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			var connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
			optionsBuilder.UseSqlServer(connectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfiguration(new ProductsConfiguration());
			modelBuilder.ApplyConfiguration(new StatusesConfiguration());
			modelBuilder.ApplyConfiguration(new AcceptedsConfiguration());
			modelBuilder.ApplyConfiguration(new OnStoresConfiguration());
			modelBuilder.ApplyConfiguration(new SoldedsConfiguration());
		}

	}
}
