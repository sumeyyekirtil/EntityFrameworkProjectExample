namespace EntityFrameworkProjectExample
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.cbDurum = new System.Windows.Forms.CheckBox();
			this.txtStokMiktari = new System.Windows.Forms.TextBox();
			this.txtUrunFiyati = new System.Windows.Forms.TextBox();
			this.txtUrunAdi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvUrunListesi = new System.Windows.Forms.DataGridView();
			this.txtAra = new System.Windows.Forms.TextBox();
			this.btnAra = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
			this.groupBox1.Controls.Add(this.lblDescription);
			this.groupBox1.Controls.Add(this.txtDescription);
			this.groupBox1.Controls.Add(this.btnSil);
			this.groupBox1.Controls.Add(this.btnGuncelle);
			this.groupBox1.Controls.Add(this.btnEkle);
			this.groupBox1.Controls.Add(this.cbDurum);
			this.groupBox1.Controls.Add(this.txtStokMiktari);
			this.groupBox1.Controls.Add(this.txtUrunFiyati);
			this.groupBox1.Controls.Add(this.txtUrunAdi);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(465, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(307, 396);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ürün Bilgileri";
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.Tan;
			this.btnSil.Enabled = false;
			this.btnSil.Location = new System.Drawing.Point(222, 342);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(63, 37);
			this.btnSil.TabIndex = 10;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Enabled = false;
			this.btnGuncelle.Location = new System.Drawing.Point(121, 342);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(95, 37);
			this.btnGuncelle.TabIndex = 10;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(24, 342);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(91, 37);
			this.btnEkle.TabIndex = 9;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// cbDurum
			// 
			this.cbDurum.AutoSize = true;
			this.cbDurum.Location = new System.Drawing.Point(121, 138);
			this.cbDurum.Name = "cbDurum";
			this.cbDurum.Size = new System.Drawing.Size(54, 20);
			this.cbDurum.TabIndex = 8;
			this.cbDurum.Text = "Aktif";
			this.cbDurum.UseVisualStyleBackColor = true;
			// 
			// txtStokMiktari
			// 
			this.txtStokMiktari.Location = new System.Drawing.Point(116, 103);
			this.txtStokMiktari.Name = "txtStokMiktari";
			this.txtStokMiktari.Size = new System.Drawing.Size(100, 22);
			this.txtStokMiktari.TabIndex = 6;
			// 
			// txtUrunFiyati
			// 
			this.txtUrunFiyati.Location = new System.Drawing.Point(116, 69);
			this.txtUrunFiyati.Name = "txtUrunFiyati";
			this.txtUrunFiyati.Size = new System.Drawing.Size(100, 22);
			this.txtUrunFiyati.TabIndex = 5;
			// 
			// txtUrunAdi
			// 
			this.txtUrunAdi.Location = new System.Drawing.Point(116, 36);
			this.txtUrunAdi.Name = "txtUrunAdi";
			this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
			this.txtUrunAdi.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Durum";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Stok Bilgisi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ürün Fiyatı";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ürün Adı";
			// 
			// dgvUrunListesi
			// 
			this.dgvUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUrunListesi.Location = new System.Drawing.Point(23, 40);
			this.dgvUrunListesi.Name = "dgvUrunListesi";
			this.dgvUrunListesi.RowHeadersWidth = 51;
			this.dgvUrunListesi.RowTemplate.Height = 24;
			this.dgvUrunListesi.Size = new System.Drawing.Size(421, 396);
			this.dgvUrunListesi.TabIndex = 6;
			this.dgvUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunListesi_CellClick);
			// 
			// txtAra
			// 
			this.txtAra.Location = new System.Drawing.Point(23, 12);
			this.txtAra.Name = "txtAra";
			this.txtAra.Size = new System.Drawing.Size(100, 22);
			this.txtAra.TabIndex = 7;
			// 
			// btnAra
			// 
			this.btnAra.Location = new System.Drawing.Point(159, 8);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(87, 26);
			this.btnAra.TabIndex = 8;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = true;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(24, 197);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(261, 126);
			this.txtDescription.TabIndex = 12;
			this.txtDescription.Text = "";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(21, 178);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 16);
			this.lblDescription.TabIndex = 13;
			this.lblDescription.Text = "Açıklama";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.txtAra);
			this.Controls.Add(this.dgvUrunListesi);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Entity Framework Ürün Yönetimi";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.CheckBox cbDurum;
		private System.Windows.Forms.TextBox txtStokMiktari;
		private System.Windows.Forms.TextBox txtUrunFiyati;
		private System.Windows.Forms.TextBox txtUrunAdi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvUrunListesi;
		private System.Windows.Forms.TextBox txtAra;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.RichTextBox txtDescription;
	}
}

