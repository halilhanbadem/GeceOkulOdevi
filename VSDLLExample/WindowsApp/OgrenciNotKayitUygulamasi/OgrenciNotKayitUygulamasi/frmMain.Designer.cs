namespace OgrenciNotKayitUygulamasi
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.txtVizeNotu = new System.Windows.Forms.TextBox();
            this.txtFinalNotu = new System.Windows.Forms.TextBox();
            this.txtButNotu = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.ledrgb = new System.Windows.Forms.Timer(this.components);
            this.clmOgrenciNumara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHarf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ledsiyah = new System.Windows.Forms.Timer(this.components);
            this.lblOgrenciSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOgrenciNumara,
            this.clmAdi,
            this.clmSoyadi,
            this.clmVize,
            this.clmFinal,
            this.clmBut,
            this.clmHarf});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(925, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(93, 183);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(151, 34);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(93, 24);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(151, 20);
            this.txtOgrenciNo.TabIndex = 2;
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(93, 48);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(151, 20);
            this.txtOgrenciAdi.TabIndex = 3;
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(93, 74);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(151, 20);
            this.txtOgrenciSoyadi.TabIndex = 4;
            // 
            // txtVizeNotu
            // 
            this.txtVizeNotu.Location = new System.Drawing.Point(93, 108);
            this.txtVizeNotu.Name = "txtVizeNotu";
            this.txtVizeNotu.Size = new System.Drawing.Size(151, 20);
            this.txtVizeNotu.TabIndex = 5;
            // 
            // txtFinalNotu
            // 
            this.txtFinalNotu.Location = new System.Drawing.Point(93, 132);
            this.txtFinalNotu.Name = "txtFinalNotu";
            this.txtFinalNotu.Size = new System.Drawing.Size(151, 20);
            this.txtFinalNotu.TabIndex = 6;
            // 
            // txtButNotu
            // 
            this.txtButNotu.Location = new System.Drawing.Point(93, 157);
            this.txtButNotu.Name = "txtButNotu";
            this.txtButNotu.Size = new System.Drawing.Size(151, 20);
            this.txtButNotu.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(93, 220);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(151, 31);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(25, 27);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(64, 13);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Öğrenci Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vize Notu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Öğrenci Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Final Notu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Büt Notu:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(272, 27);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(98, 18);
            this.lblSonuc.TabIndex = 16;
            this.lblSonuc.Text = "ssssssssss";
            this.lblSonuc.Visible = false;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(270, 45);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(122, 25);
            this.lblDurum.TabIndex = 17;
            this.lblDurum.Text = "ssssssssss";
            this.lblDurum.Visible = false;
            // 
            // ledrgb
            // 
            this.ledrgb.Interval = 500;
            this.ledrgb.Tick += new System.EventHandler(this.led_Tick);
            // 
            // clmOgrenciNumara
            // 
            this.clmOgrenciNumara.HeaderText = "Öğrenci Numarası";
            this.clmOgrenciNumara.Name = "clmOgrenciNumara";
            this.clmOgrenciNumara.ReadOnly = true;
            // 
            // clmAdi
            // 
            this.clmAdi.HeaderText = "Adı";
            this.clmAdi.Name = "clmAdi";
            this.clmAdi.ReadOnly = true;
            // 
            // clmSoyadi
            // 
            this.clmSoyadi.HeaderText = "Soyadı";
            this.clmSoyadi.Name = "clmSoyadi";
            this.clmSoyadi.ReadOnly = true;
            // 
            // clmVize
            // 
            this.clmVize.HeaderText = "Vize Notu";
            this.clmVize.Name = "clmVize";
            this.clmVize.ReadOnly = true;
            // 
            // clmFinal
            // 
            this.clmFinal.HeaderText = "FinalNotu";
            this.clmFinal.Name = "clmFinal";
            this.clmFinal.ReadOnly = true;
            // 
            // clmBut
            // 
            this.clmBut.HeaderText = "Büt Notu";
            this.clmBut.Name = "clmBut";
            this.clmBut.ReadOnly = true;
            // 
            // clmHarf
            // 
            this.clmHarf.HeaderText = "Harflendirme Durumu";
            this.clmHarf.Name = "clmHarf";
            this.clmHarf.ReadOnly = true;
            // 
            // ledsiyah
            // 
            this.ledsiyah.Interval = 500;
            this.ledsiyah.Tick += new System.EventHandler(this.ledsiyah_Tick);
            // 
            // lblOgrenciSayisi
            // 
            this.lblOgrenciSayisi.AutoSize = true;
            this.lblOgrenciSayisi.Location = new System.Drawing.Point(9, 258);
            this.lblOgrenciSayisi.Name = "lblOgrenciSayisi";
            this.lblOgrenciSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciSayisi.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 575);
            this.Controls.Add(this.lblOgrenciSayisi);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtButNotu);
            this.Controls.Add(this.txtFinalNotu);
            this.Controls.Add(this.txtVizeNotu);
            this.Controls.Add(this.txtOgrenciSoyadi);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Kayıt Uygulamasına Hoşgeldiniz!";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harf;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.TextBox txtVizeNotu;
        private System.Windows.Forms.TextBox txtFinalNotu;
        private System.Windows.Forms.TextBox txtButNotu;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Timer ledrgb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOgrenciNumara;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHarf;
        private System.Windows.Forms.Timer ledsiyah;
        private System.Windows.Forms.Label lblOgrenciSayisi;
    }
}

