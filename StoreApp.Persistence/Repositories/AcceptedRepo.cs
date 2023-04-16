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
	public class AcceptedRepo
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
						StatusName = "Accepted"
					};
					db.Products.Add(product);

					var accepted = new Accepted
					{
						Id = Guid.NewGuid(),
						Name = product.Name,
						Cost = product.Cost,
						Product = product,
						ProductId = Id
					};
					db.Accepteds.Add(accepted);

					db.SaveChanges();
				}
			}
		}
		public List<Accepted> ReadAll()
		{
			using (var db = new StoreAppDBContext())
			{
				var accept = db.Accepteds.ToList();
				if (accept != null)
				{
					return accept;
				}

				return null;
			}
		}

		public void EditStatus(Guid id, string name)
		{
			using (var db = new StoreAppDBContext())
			{
				var accepted = db.Accepteds.Include(a => a.Product).First(a => a.Id == id);
				if (accepted != null)
				{
					var product = accepted.Product;
					if (product != null)
					{
						var onStore = new OnStore
						{
							Id = Guid.NewGuid(),
							Name = product.Name,
							Cost = product.Cost,
							Product = product,
							ProductId = product.Id
						};

						db.Accepteds.Remove(accepted);
						product.StatusName = name;
						db.OnStores.Add(onStore);
						db.SaveChanges();
					}
				}
			}
		}

		public void Delete(Guid id)
		{
			using (var db = new StoreAppDBContext())
			{
				var accepted = db.Accepteds.Include(a => a.Product).First(a => a.Id == id);
				if (accepted != null)
				{
					var product = accepted.Product;
					db.Products.Remove(product);
					db.SaveChanges();
				}
			}
		}

	}
}
