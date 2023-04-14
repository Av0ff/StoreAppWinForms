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
	public class StatusRepo
	{
		public void Create(string name)
		{
			using(var db = new StoreAppDBContext())
			{
				var status = new Status
				{
					Name = name
				};

				db.Statuses.Add(status);
				db.SaveChanges();
			}
		}
		public List<string> ReadAll()
		{
			using (var db = new StoreAppDBContext())
			{
				var statuses = db.Statuses.Select(s => s.Name).ToList();
				if (statuses != null)
				{
					return statuses;
				}

				return null;
			}
		}

		public void Delete(string name)
		{
			using (var db = new StoreAppDBContext())
			{
				var status = db.Statuses.Find(new object[] { name });
				if (status != null)
				{
					db.Statuses.Remove(status);
					db.SaveChanges();
				}
			}
		}

	}
}
