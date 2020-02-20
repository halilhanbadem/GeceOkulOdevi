using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayitUygulamasi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        CallDLL.CallDLLEx Ogrenci = new CallDLL.CallDLLEx();

        public float Ortalama;
        public string Sonuc, Harflendirme;
        bool hesapKontrol = false;

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        public void setOgrenciBilgiler()
        {
            Ogrenci.OgrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
            Ogrenci.Adi = txtOgrenciAdi.Text;
            Ogrenci.Soyadi = txtOgrenciSoyadi.Text;
            Ogrenci.Vize = Convert.ToInt32(txtVizeNotu.Text);
            Ogrenci.Final = Convert.ToInt32(txtFinalNotu.Text);
            Ogrenci.But = Convert.ToInt32(txtButNotu.Text);
        }


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                

            setOgrenciBilgiler();

            Ortalama = Ogrenci.OrtalamaHesapla(Ogrenci.Vize, Ogrenci.Final, Ogrenci.But);
            Harflendirme = Ogrenci.HarfNotuHesapla(Ortalama);

            lblSonuc.Text = Ogrenci.Adi + " adlı öğrenci " + Ortalama + " ortalaması ile " + Harflendirme + " notu almıştır.";
            lblSonuc.Visible = true;
            lblDurum.Visible = true;    

            if (Harflendirme == "FF" || Harflendirme == "DD")
            {
                Sonuc = "KALDI";
                lblDurum.Text = "Öğrenci Durumu => " + Sonuc;
                lblDurum.ForeColor = Color.Red;
                ledrgb.Enabled = true;
                ledsiyah.Enabled = true;
                hesapKontrol = true;

                }
            else
            {
                Sonuc = "GEÇTİ";
                lblDurum.Text = "Öğrenci Durumu => " + Sonuc;
                lblDurum.ForeColor = Color.Green;
                ledrgb.Enabled = true;
                ledsiyah.Enabled = true;
                hesapKontrol = true;

                }


            if (Harflendirme == "0x0")
            {
                  lblSonuc.Visible = false;
                  lblDurum.Visible = false;
                  hesapKontrol = false;
                  MessageBox.Show("Girilen notlar aralığında - veya 100 üzerinden not tespit edildi. Lütfen kurallara uygun şekilde not giriniz!", "Kuralsız Not", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
              

             
            }
            catch (Exception hata)
            {
                lblSonuc.Visible = false;
                lblDurum.Visible = false;
                hesapKontrol = false;
                MessageBox.Show("Bilinmeyen bir hata alındı! Hata açıklaması: " + hata.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void ledsiyah_Tick(object sender, EventArgs e)
        {
            lblDurum.ForeColor = Color.Black;
            ledrgb.Enabled = true;
            ledsiyah.Enabled = false; 
        }

        public void gridRenklendir()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[6].Value == "FF" || row.Cells[6].Value == "DD")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                } else
                if ((row.Cells[6].Value == "CC" || row.Cells[6].Value == "BB" || row.Cells[6].Value == "AA"))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                } 
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 == 20)
            {
                MessageBox.Show("20'den fazla öğrenci girilemez!", "Öğrenci Aşımı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else { 
            if (hesapKontrol == true)
            {
                hesapKontrol = false;
                setOgrenciBilgiler();
                dataGridView1.Rows.Add(Ogrenci.OgrenciNo, Ogrenci.Adi, Ogrenci.Soyadi, Ogrenci.Vize, Ogrenci.Final, Ogrenci.But, Harflendirme);
                gridRenklendir();
                lblOgrenciSayisi.Text = "Öğrenci Sayınız: " + (dataGridView1.Rows.Count - 1).ToString();
            } else
            {
                MessageBox.Show("Önce hesaplayın, sonra veriyi kaydetmeyi deneyiniz!", "Hesabını Veremeyeceğiniz Kaydı Tutmayınız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
               }
        }

        private void led_Tick(object sender, EventArgs e)
        {
            if (Sonuc == "KALDI")
            {
                lblDurum.ForeColor = Color.Red;
                lblDurum.Font = new Font(lblDurum.Font.Name, lblDurum.Font.Size + 1);
                //hocam gece gece emre ile bazı testler yaptık...
            }

            if (Sonuc == "GEÇTİ")
            {
                lblDurum.ForeColor = Color.Green;
            }

            ledrgb.Enabled = false;
            ledsiyah.Enabled = true;
        }
    }
}
