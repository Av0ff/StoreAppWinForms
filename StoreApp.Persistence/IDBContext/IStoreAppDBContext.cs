using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Persistence.IDBContext
{
	public interface IStoreAppDBContext
	{
		DbSet<Product> Products { get; set; }
		DbSet<Status> Statuses { get; set; }
		DbSet<Accepted> Accepteds { get; set; }
		DbSet<OnStore> OnStores { get; set; }
		DbSet<Solded> Soldeds { get; set; }
	}
}
