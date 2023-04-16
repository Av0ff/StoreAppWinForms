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
	public class SoldedsRepo
	{
		public void Create(ProductViewModel model)
		{
			using (var db = new StoreAppDBContext())
			{
				if (model != null)
				{
					var Id = Guid.NewGuid();

					var product = new Product
					{
						Id = Id,
						Name = model.Name,
						Cost = model.Cost,
						StatusName = "Sold"
					};
					db.Products.Add(product);

					var solded = new Solded
					{
						Id = Guid.NewGuid(),
						Name = product.Name,
						Cost = product.Cost,
						Product = product,
						ProductId = Id
					};
					db.Soldeds.Add(solded);

					db.SaveChanges();
				}
			}
		}

		public List<Solded> ReadAll()
		{
			using (var db = new StoreAppDBContext())
			{
				var sold = db.Soldeds.ToList();
				if (sold != null)
				{
					return sold;
				}

				return null;
			}
		}

		public void Delete(Guid id)
		{
			using (var db = new StoreAppDBContext())
			{
				var sold = db.Soldeds.Include(s => s.Product).First(s => s.Id == id);
				if (sold != null)
				{
					var product = sold.Product;
					db.Products.Remove(product);
					db.SaveChanges();
				}
			}
		}

	}
}
