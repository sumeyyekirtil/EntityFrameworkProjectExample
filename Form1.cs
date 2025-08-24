using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ENTITY FRAMEWORK : Ado Net işlemlerini daha kolay ve hızlı yapabilen kütüphanedir
//Sql işlemlerini çok kolaylaştırır.
//Crud işlemleri ve büyük uygulama arkaplan kodlama işleminde Ado Net + Stored Procedure kullanılır.
//Genelde Entity Framework kullanılır küçük uygulamalarda (hızlı işlemlerde)
//Ado Net gibi hazır gelmiyor sonradan kütüphane olarak yükleniyor
//savechanges : unit of work pattern -> veritabanı işlemlerinin yönetimini kolaylaştıran ve işlemleri birbirleriyle bağlantılı bir şekilde gruplandırmayı sağlayan yazılım tasarım deseni.

namespace EntityFrameworkProjectExample
{
	//ENTITY FRAMEWORK : import : project - sağ tık - manage NuGet packages : entity framework install - I accept
	//2. yöntemi : Solution Explorer - sağ tık - manage NuGet packages for solition - install edeceğimiz projeyi seçme işlemi yaptırır (birden fazla proje seçilebilir)
	//DB - VT işlemleri : project - sağ tık - add class -  UrunDbModel
	//UrunDbModel : kütüphane import - using System.Data.Entity;
	//Referans almak : project - referance - add referance - istenilen projeyi ekleme yapılır
	//app.config : ayarların tutulduğu yer - proje bilgileri bulunur
	//app.config connection string ekleme : connectionString tagleri aç/kapat add ekleyip name özelliği ile base kısmındaki ismi import edilir. connectionString bağlantı adresi string olarak yazılır. İçine provider adı ekleme using sqlclient adresini yazmak
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		UrunDbModel context = new UrunDbModel(); //dal gibi oluşturduk nesneyi

		private void Form1_Load(object sender, EventArgs e)
		{
			dgvUrunListesi.DataSource = context.Urunler.ToList(); //entity framework ile vt daki ürünleri çekme
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{//bu kısmı try - catch bloğuna aldık
			try
			{
				//ürün nesnesini de bu alana alınması gerekli
				var urun = new Product
				{
					Name = txtUrunAdi.Text,
					Price = Convert.ToDecimal(txtUrunFiyati.Text),
					Stok = Convert.ToInt32(txtStokMiktari.Text),
					Description = Convert.ToString(txtDescription.Text),
					Durum = cbDurum.Checked
				};

				context.Urunler.Add(urun); //context nesnesindeki products tablosuna ürün ekle
				int sonuc = context.SaveChanges(); //context deki değişiklikleri db yansıt 
												   //savechanges : eğer sonuç 0 dan büyük değilse yapılan değişiklikleri geri al vt işlemi sil görevi görür
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = context.Urunler.ToList(); //ekrandaki dgv tekrar yüklüyoruz yoksa ekranda gözükmez!

					txtUrunAdi.Clear();
					txtUrunFiyati.Clear();
					txtStokMiktari.Clear();
					txtDescription.Clear();
					txtAra.Clear();
					cbDurum.Checked = false;

					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception) //hata kısmı error olursa detaylı çzüm için ekranda gösterilir (güvenlik açığı).
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!");
			}
		}
		private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
		{ //sıralamalar (cells) doğru olmazsa belirtilen atama geçerli değil hatası alınır 
			txtUrunAdi.Text = dgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
			txtUrunFiyati.Text = dgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
			txtStokMiktari.Text = dgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
			txtDescription.Text = dgvUrunListesi.CurrentRow.Cells[5].Value.ToString();
			cbDurum.Checked = (bool)dgvUrunListesi.CurrentRow.Cells[4].Value;

			btnEkle.Enabled = false;
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{//güncellemede ve sil de id i unutulmamalı
			try
			{
				int id = (int)dgvUrunListesi.CurrentRow.Cells[0].Value; //seçilen ürün id al
				var urun = context.Urunler.Find(id); //db eşleşen id bulunan ürünün özelliklerini değiştir

				urun.Durum = cbDurum.Checked;
				urun.Description = Convert.ToString(txtDescription.Text);
				urun.Stok = Convert.ToInt32(txtStokMiktari.Text);
				urun.Price = Convert.ToDecimal(txtUrunFiyati.Text);
				urun.Name = txtUrunAdi.Text;

				int sonuc = context.SaveChanges(); //context deki değişiklikleri vt yansıt
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = context.Urunler.ToList(); //ekrandaki dgv tekrar yüklüyoruz yoksa ekranda gözükmez!

					txtUrunAdi.Clear();
					txtUrunFiyati.Clear();
					txtStokMiktari.Clear();
					txtDescription.Clear();
					txtAra.Clear();
					cbDurum.Checked = false;

					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!" + hata);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Kaydı silmek istiyor musunuz!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					var product = context.Urunler.Find((int)dgvUrunListesi.CurrentRow.Cells[0].Value); //kayıtı bul
					context.Urunler.Remove(product); //kayıtı sil

					int sonuc = context.SaveChanges(); //id ulaşılan yere getirdik
					if (sonuc > 0)
					{
						dgvUrunListesi.DataSource = context.Urunler.ToList();
						btnEkle.Enabled = true;
						btnGuncelle.Enabled = false;
						btnSil.Enabled = false;

						txtUrunAdi.Clear();
						txtUrunFiyati.Clear();
						txtStokMiktari.Clear();
						txtDescription.Clear();
						txtAra.Clear();
						cbDurum.Checked = false;

						MessageBox.Show("Kayıt Silindi!");
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Hata Oluştu!");
				}
			}
		}

		private void btnAra_Click(object sender, EventArgs e)
		{
			dgvUrunListesi.DataSource = context.Urunler.Where(p => p.Name.Contains(txtAra.Text)).ToList(); //p - product tablosunu simgeliyor (lambda expression)
			//ürün adı içeriyorsa (contains) txtara.text e gönder
		}
	}
}