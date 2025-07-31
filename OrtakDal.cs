using System.Data; //vt işlemleri için gerekli
using System.Data.SqlClient; //entity kütüphaneleri

namespace EntityFrameworkProjectExample
{
	public class OrtakDal
	{
		internal SqlConnection _connection = new SqlConnection(@"server=ASUS-PRO; database=GiyimDB; Integrated Security=True;");

		internal void ConnectionKontrol()//Veritabanı bağlantımızı kontrol eden metot
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();//Veritabanı bağlantısını aç
			}
		}
		public DataTable GetDataTable(string sqlSorgu)
		{
			DataTable dt = new DataTable();

			ConnectionKontrol();

			SqlCommand command = new SqlCommand(sqlSorgu, _connection);

			SqlDataReader reader = command.ExecuteReader();

			dt.Load(reader);

			reader.Close(); // veritabanından okuyucuyu kapat
			_connection.Close(); // veritabanı bağlantısını kapat
			command.Dispose(); // sql komut nesnesini yok et

			return dt;
		}
	}
}
