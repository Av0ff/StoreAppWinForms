using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.Persistence.IDBContext;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Persistence.Repositories
{
	public class OnStoreRepo : IRepo<OnStore>
	{
		public void Create(ProductViewModel model)
		{
			using(var db = new StoreAppDBContext())
			{
				if (model != null)
				{
					var Id = Guid.NewGuid();

					var product = new Product
					{
						Id = Id,
						Name = model.Name,
						Cost = model.Cost,
						StatusName = "OnStore"
					};
					db.Products.Add(product);

					var onStore = new OnStore
					{
						Id = Guid.NewGuid(),
						Name = product.Name,
						Cost = product.Cost,
						Product = product,
						ProductId = Id
					};
					db.OnStores.Add(onStore);

					db.SaveChanges();
				}
			}
		}

		public List<OnStore> ReadAll()
		{
			using (var db = new StoreAppDBContext())
			{
				var onStore = db.OnStores.ToList();
				if (onStore != null)
				{ 
					return onStore;
				}

				return null;
			}
		}

		public void EditStatus(Guid id, string name)
		{
			using (var db = new StoreAppDBContext())
			{
				var onStore = db.OnStores.Include(os => os.Product).First(os => os.Id == id);
				if (onStore != null)
				{
					var product = onStore.Product;
					if (product != null)
					{
						var solded = new Solded
						{
							Id = Guid.NewGuid(),
							Name = product.Name,
							Cost = product.Cost,
							Product = product,
							ProductId = product.Id
						};

						db.OnStores.Remove(onStore);
						product.StatusName = name;
						db.Soldeds.Add(solded);
						db.SaveChanges();
					}
				}
			}
		}

		public void Delete(Guid id)
		{
			using (var db = new StoreAppDBContext())
			{
				var onStore = db.OnStores.Include(os => os.Product).First(os => os.Id == id);
				if (onStore != null)
				{
					var product = onStore.Product;
					db.Products.Remove(product);
					db.SaveChanges();
				}
			}
		}

	}
}
