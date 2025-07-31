using System;
using System.Collections.Generic;
using System.Data; //vt işlemleri için gerekli
using System.Data.Common;
using System.Data.SqlClient; //ado.net kütüphaneleri

namespace EntityFrameworkProjectExample
{
	public class CategoryDal : OrtakDal
	{
		public int Add(Category category)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Insert into Category (Name, Description, CreateDate, Active) values (@Name, @Description, @CreateDate, @Durum)", _connection);
			command.Parameters.AddWithValue("@Name", category.Name);
			command.Parameters.AddWithValue("@Description", category.Description);
			command.Parameters.AddWithValue("@CreateDate", category.CreateDate);
			command.Parameters.AddWithValue("@Durum", category.Active);
			sonuc = command.ExecuteNonQuery();
			command.Dispose();
			_connection.Close();
			return sonuc;
		}

		public int Update(Category category)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Update Category set Name=@Name, Description=@Description, CreateDate=@CreateDate, Active=@Durum where Id=@KatId", _connection);
			command.Parameters.AddWithValue("@KatId", category.Id);
			command.Parameters.AddWithValue("@Name", category.Name);
			command.Parameters.AddWithValue("@Description", category.Description);
			command.Parameters.AddWithValue("@CreateDate", category.CreateDate);
			command.Parameters.AddWithValue("@Durum", category.Active);
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
				"Delete From Category where Id=@id", _connection);
			command.Parameters.AddWithValue("@id", id);
			sonuc = command.ExecuteNonQuery();
			command.Dispose();
			_connection.Close();
			return sonuc;
		}
		public Category Find(int id)
		{
			Category category = null;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"select * From Category where Id=@id", _connection);
			command.Parameters.AddWithValue("@id", id);
			var reader = command.ExecuteReader();
			if (reader != null)
			{
				while (reader.Read())
				{
					category.Id = reader.GetInt32(0);
					category.Name = reader.GetString(1);
					category.Description = reader.GetString(2);
					category.Active = reader.GetBoolean(3);
					category.CreateDate = reader.GetDateTime(4);
				}
			}
			command.Dispose();
			_connection.Close();
			return category;
		}
	}
}