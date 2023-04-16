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
	public class ProductRepo
	{
		//public void Create(ProductViewModel model)
		//{
		//	using(var db = new StoreAppDBContext(IStoreAppDBContext.Options.Options))
		//	{
		//		if (model != null)
		//		{
		//			var product = new Product 
		//			{
		//				Id = Guid.NewGuid(),
		//				Name = model.Name,
		//				Cost = model.Cost,
		//				StatusName = model.Status
		//				//статус под вопросом, возможна ошибка
		//			};

		//			db.Products.Add(product);
		//			db.SaveChanges();
		//		}
		//	}
		//}
		public ProductViewModel Read(Guid id)
		{
			using (var db = new StoreAppDBContext())
			{
				var product = db.Products.Find(new object[] { id });
				if (product != null)
				{
					var model = new ProductViewModel
					{
						Name = product.Name,
						Cost = product.Cost,
						Status = product.StatusName
					};

					return model;
				}

				return null;
			}
		}

		public List<Product> ReadAll()
		{
			using (var db = new StoreAppDBContext())
			{
				var product = db.Products.ToList();
				if (product != null)
				{
					return product;
				}

				return null;
			}
		}

		public ProductViewModel Update(Guid id, ProductViewModel model)
		{
			using (var db = new StoreAppDBContext())
			{
				var product = db.Products.Find(new object[] {id});
				if (product != null)
				{
					product.Name = model.Name;
					product.Cost = model.Cost;
					product.StatusName = model.Status;

					db.SaveChanges();

					var viewModel = new ProductViewModel
					{
						Name = product.Name,
						Cost = product.Cost,
						Status = product.StatusName
					};

					return viewModel;
				}

				return null;
			}
		}

		public void Delete(Guid id)
		{
			using (var db = new StoreAppDBContext())
			{
				var product = db.Products.Find(new object[] { id });
				if (product != null)
				{
					db.Products.Remove(product);
					db.SaveChanges();
				}

			}
		}

	}
}
