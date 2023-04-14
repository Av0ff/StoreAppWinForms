using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Cost { get; set; }
		public Status Status { get; set; }
		public string StatusName { get; set; }
	}
}
