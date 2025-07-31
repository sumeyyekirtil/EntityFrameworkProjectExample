using System.Data.Entity; //entity framework kütüphanesi
using EntityFrameworkProjectExample;

namespace EntityFrameworkProjectExample
{
	public class UrunDbModel : DbContext // Entity frameworkün DbContext sınıfından miras alındı
	{
		public UrunDbModel() : base("name=UrunDbModel") // Entity frameworkün DbContext sınıfındaki base e connection string ismini gönderdik
		{

		}

		public virtual DbSet<Category> Categoriler { get; set; }
		public virtual DbSet<Product> Urunler { get; set; }

	}
}