using StoreApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Persistence.Repositories
{
	public interface IRepo<T>
	{
		public List<T> ReadAll();
		public void Delete(Guid id);
	}
}
