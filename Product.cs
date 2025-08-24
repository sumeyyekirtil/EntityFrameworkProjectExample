using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProjectExample
{
	public class Product
	{ //ürün propları
		public int Id { get; set; }
		public string Name { get; set; } //name
		public decimal Price { get; set; } //price
		public int Stok { get; set; } //stock
		public bool Durum { get; set; } //active
		public string Description { get; set; } //açıklama
	}
}
