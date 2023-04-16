using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data
{
	public class Accepted
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Cost { get; set; }
		public Product Product { get; set; }
		public Guid ProductId { get; set; }
	}
}
