using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProjectExample
{
	public class Product
	{
		public int ProductId { get; set; }
		public string Department { get; set; }
		public int Upper { get; set; }
		public int Lower { get; set; }
		public DateTime CreateDate { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Stock { get; set; }
		public decimal Price { get; set; }
		public bool Active { get; set; }
	}
}