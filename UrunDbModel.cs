using System.Data.Entity; //entity framework kütüphanesi
using EntityFrameworkProjectExample;

namespace EntityFrameworkProjectExample
{
	public class UrunDbModel : DbContext // Entity frameworkün DbContext sınıfından miras alındı
	{
		public UrunDbModel() : base("name=UrunDbModel") // Entity frameworkün DbContext sınıfındaki base e connection string ismini gönderdik
		{

		}

		public virtual DbSet<Category> Kategoriler { get; set; } //Category sınıfı tanımlamak için 1.yol -> bu sayfada tanımlama, 2.yol -> başka projedeki category class ı referance almak
	   
		//Referans almak : project - referance - add referance - istenilen projeyi ekleme yapılır
		public virtual DbSet<Product> Urunler { get; set; }
	}
}