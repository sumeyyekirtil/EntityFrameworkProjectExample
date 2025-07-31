using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProjectExample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		UrunDbModel context = new UrunDbModel();
		private void Form1_Load(object sender, EventArgs e)
		{
			dgvUrunListesi.DataSource = context.Urunler.ToList(); // Entity framework ile vt ürünleri çeker
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				var urun = new Product
				{
					Name = txtUrunAdi.Text,
					Stock = Convert.ToInt32(txtStokMiktari.Text),
					Price = Convert.ToDecimal(txtUrunFiyati.Text),
					Active = cbDurum.Checked
				};
				context.Urunler.Add(urun); //context nesnesindeki ürün tablosuna ekle
				int sonuc = context.SaveChanges(); //context değişiklikleri vt yansıt
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = context.Urunler.ToList();
					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Tüm Alanları Doldurmayı Unutmayınız!" + hata.Message);
			}
		}
		private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtUrunAdi.Text = dgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
			txtUrunFiyati.Text = dgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
			txtStokMiktari.Text = dgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
			cbDurum.Checked = (bool)dgvUrunListesi.CurrentRow.Cells[4].Value;

			btnEkle.Enabled = false;
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)dgvUrunListesi.CurrentRow.Cells[0].Value; // seçilen ürünün id sini al
				var urun = context.Urunler.Find(id); // veritabanındaki ürünlerden bu id ile eşleşeni bul
													 // veritabanından bulunan ürünün özelliklerini değiştir
				urun.Active = cbDurum.Checked;
				urun.Stock = Convert.ToInt32(txtStokMiktari.Text);
				urun.Price = Convert.ToDecimal(txtUrunFiyati.Text);
				urun.Name = txtUrunAdi.Text;

				int sonuc = context.SaveChanges(); //değişiklikleri vt kaydet

				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = context.Urunler.ToList();
					btnEkle.Enabled = true;
					btnGuncelle.Enabled = false;
					btnSil.Enabled = false;
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!" + hata.Message);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					var product = context.Urunler.Find((int)dgvUrunListesi.CurrentRow.Cells[0].Value);

					context.Urunler.Remove(product);
					int sonuc = context.SaveChanges();
					if (sonuc > 0)
					{
						dgvUrunListesi.DataSource = context.Urunler.ToList();
						btnEkle.Enabled = true;
						btnGuncelle.Enabled = false;
						btnSil.Enabled = false;
						MessageBox.Show("Kayıt Silindi!");
					}
				}
				catch (Exception hata)
				{
					MessageBox.Show("Hata Oluştu! " + hata.Message);
				}
			}
		}

		private void btnAra_Click(object sender, EventArgs e)
		{
			dgvUrunListesi.DataSource = context.Urunler.Where(p => p.Name.Contains(txtAra.Text)).ToList();
		}
	}
}