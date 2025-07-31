using System;
using System.Collections.Generic;
using System.Data; //vt işlemleri için gerekli
using System.Data.SqlClient; //entity kütüphaneleri

namespace EntityFrameworkProjectExample
{
	public class ProductDal : OrtakDal
	{
		public List<Product> GetAll()
		{
			var products = new List<Product>();

			ConnectionKontrol();

			SqlCommand command = new SqlCommand("select * from ProductDetails", _connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read()) // reader nesnesi içerisinde okunacak kayıt olduğu sürece
			{
				var product = new Product()
				{
					ProductId = Convert.ToInt32(reader["Id"]),
					Name = Convert.ToString(reader["UrunAdi"]), //convert ile ekledim!
					Stock = Convert.ToInt32(reader["StokMiktari"]),
					Price = Convert.ToDecimal(reader["UrunFiyati"]),
					Active = Convert.ToBoolean(reader["Durum"]),
					Department = Convert.ToString(reader["Departman"]),
					Upper = Convert.ToInt32(reader["UstTakim"]),
					Lower = Convert.ToInt32(reader["AltTakim"]),
					CreateDate = Convert.ToDateTime(reader["DegiştirmeTarihi"]),
					Description = Convert.ToString(reader["Açiklama"])
				};
				products.Add(product); // db den okunan ürünü listeye ekle
			}
			reader.Close(); // veritabanından okuyucuyu kapat
			_connection.Close(); // veritabanı bağlantısını kapat
			command.Dispose(); // sql komut nesnesini yoket

			return products;
		}
		public int Add(Product product)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Insert into ProductDetails values(@UrunAdi,@UrunFiyati,@StokMiktari,@Durum,@Departman,@Üst,@Alt,@Açiklama,@Tarih)", _connection);

			command.Parameters.AddWithValue("@UrunAdi", product.Name);
			command.Parameters.AddWithValue("@UrunFiyati", product.Price);
			command.Parameters.AddWithValue("@StokMiktari", product.Stock);
			command.Parameters.AddWithValue("@Durum", product.Active);
			command.Parameters.AddWithValue("@Departman", product.Department);
			command.Parameters.AddWithValue("@Üst", product.Upper);
			command.Parameters.AddWithValue("@Alt", product.Lower);
			command.Parameters.AddWithValue("@Açiklama", product.Description);
			command.Parameters.AddWithValue("@Tarih", product.CreateDate);
			sonuc = command.ExecuteNonQuery();
			command.Dispose();
			_connection.Close();
			return sonuc;
		}
		public int Update(Product product)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Update ProductDetails set Name=@UrunAdi, Price=@UrunFiyati, Stock=@StokMiktari, Active=@Durum, Department=@Departman, Upper=@Üst, Lower=@Alt, Description=@Aciklama, CreateDate=@Tarih @where ProductId=@id", _connection);
			command.Parameters.AddWithValue("@UrunAdi", product.Name);
			command.Parameters.AddWithValue("@UrunFiyati", product.Price);
			command.Parameters.AddWithValue("@StokMiktari", product.Stock);
			command.Parameters.AddWithValue("@Durum", product.Active);
			command.Parameters.AddWithValue("@Departman", product.Department);
			command.Parameters.AddWithValue("@Üst", product.Upper);
			command.Parameters.AddWithValue("@Alt", product.Lower);
			command.Parameters.AddWithValue("@Aciklama", product.Description);
			command.Parameters.AddWithValue("@Tarih", product.CreateDate);
			sonuc = command.ExecuteNonQuery();
			command.Dispose();
			_connection.Close();
			return sonuc;
		}

		public int Delete(int id)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Delete From ProductDetails where ProductId=@id", _connection);

			command.Parameters.AddWithValue("@id", id);
			sonuc = command.ExecuteNonQuery();
			command.Dispose();
			_connection.Close();
			return sonuc;
		}
	}
}
