/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3 - Proje Ödevi
**				ÖĞRENCİ ADI............: Abdullah Akçam
**				ÖĞRENCİ NUMARASI.......: g140910076
**                         DERSİN ALINDIĞI GRUP...: 2. Öğretim A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NDP_Proje.UrunTurleri;

namespace NDP_Proje
{
    public partial class Form1 : Form
    {
        // Ürünelerin tutulduğu property
        private List<Urun> urunler;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            VeriOlustur.form1 = this;
            VeriOlustur.UrunleriOlustur();
            if (VeriOlustur.Urunler != null && VeriOlustur.Urunler.Any())
            {
                urunler = VeriOlustur.Urunler;
            }
            else
            {
                MessageBox.Show("Urunleri olustururken hata meydana geldi!");
            }
        }

        #region Butonlar

        /* Bu bölümde buton atamaları yapılmaktadır. Butonlara tıklandığında Veriler.cs den
         * alınıp oluşturularn veriler ile DataGridView bileşenleri doldurulmaktadır.
         */

        private void satilanUrunlerButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (var urun in urunler)
                switch (urun)
                {
                    case Bayan o:
                        dataGridView1.Rows.Add(urun.SatisTarihi.ToString("dd-MM-yyyy"), o.TurIsmi,
                            urun.Musteri.AdSoyad);
                        break;
                    case Erkek y:
                        dataGridView1.Rows.Add(urun.SatisTarihi.ToString("dd-MM-yyyy"), y.TurIsmi,
                            urun.Musteri.AdSoyad);
                        break;
                    case Cocuk i:
                        dataGridView1.Rows.Add(urun.SatisTarihi.ToString("dd-MM-yyyy"), i.TurIsmi,
                            urun.Musteri.AdSoyad);
                        break;
                }

            dataGridView1.CurrentCell = null;
        }

        private void buttonSiparisEdilen_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            // Her ürün için tedarikçi ataması yapar
            foreach (var urun in urunler)
                switch (urun)
                {
                    case Bayan bayan:
                        dataGridView2.Rows.Add(urun.AlisTarihi.ToString("dd-MM-yyyy"), bayan.TurIsmi,
                            urun.Tedarikci.AdSoyad);
                        break;
                    case Erkek erkek:
                        dataGridView2.Rows.Add(urun.AlisTarihi.ToString("dd-MM-yyyy"), erkek.TurIsmi,
                            urun.Tedarikci.AdSoyad);
                        break;
                    case Cocuk cocuk:
                        dataGridView2.Rows.Add(urun.AlisTarihi.ToString("dd-MM-yyyy"), cocuk.TurIsmi,
                            urun.Tedarikci.AdSoyad);
                        break;
                }

            dataGridView2.CurrentCell = null;
        }

        private void buttonGelirGider_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            // Her ürün için tedarikçi ataması yapar
            var bilanco = new Bilanco(urunler);
            foreach (var gun in bilanco.Gunler)
                dataGridView3.Rows.Add(gun.GununTarihi.ToString("dd-MM-yyyy"), gun.SatisToplamlar, gun.AlisToplamlar);
            dataGridView3.CurrentCell = null;
        }

        /* Buradaki ürün türleri genel türler olduğu için (Örneğin erkek giyimde pantolon olabilir)
         * Ürün türlerini tek tek stoklarına göre listelemek ile hepsini toplayıp listelemek arasında
         * kararsız kaldım. O yüzden ikinci yoldan yaptım
         */

        private void buttonDepodakiUrunleriListele_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            var bayanToplam = 0;
            var erkekToplam = 0;
            var cocukToplam = 0;
            foreach (var urun in urunler)
                switch (urun)
                {
                    case Bayan bayan:
                        bayanToplam += urun.Stok.DepodakiUrunler;
                        break;
                    case Erkek erkek:
                        erkekToplam += urun.Stok.DepodakiUrunler;
                        break;
                    case Cocuk cocuk:
                        cocukToplam += urun.Stok.DepodakiUrunler;
                        break;
                }

            if (bayanToplam < 1 || erkekToplam < 1 || cocukToplam < 1)
            {
                MessageBox.Show("Yetersiz stok. Satış yapılamaz!");
            }
            
            dataGridView4.Rows.Add(new Bayan().TurIsmi, bayanToplam);
            dataGridView4.Rows.Add(new Erkek().TurIsmi, erkekToplam);
            dataGridView4.Rows.Add(new Cocuk().TurIsmi, cocukToplam);
            dataGridView4.CurrentCell = null;
        }

        private void buttonRaftakiUrunleriListele_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Clear();
            var bayanToplam = 0;
            var erkekToplam = 0;
            var cocukToplam = 0;
            foreach (var urun in urunler)
                switch (urun)
                {
                    case Bayan bayan:
                        bayanToplam += urun.Stok.RaftakiUrunler;
                        break;
                    case Erkek erkek:
                        erkekToplam += urun.Stok.RaftakiUrunler;
                        break;
                    case Cocuk cocuk:
                        cocukToplam += urun.Stok.RaftakiUrunler;
                        break;
                }

            dataGridView5.Rows.Add(new Bayan().TurIsmi, bayanToplam);
            dataGridView5.Rows.Add(new Erkek().TurIsmi, erkekToplam);
            dataGridView5.Rows.Add(new Cocuk().TurIsmi, cocukToplam);
            dataGridView5.CurrentCell = null;
        }

        private void buttonSiparisVer_Click(object sender, EventArgs e)
        {
            var radioBtn = this.Controls
                .OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "radioButtonErkek":
                        VeriOlustur.SiparisEkle(0);
                        break;
                    case "radioButtonBayan":
                        VeriOlustur.SiparisEkle(1);
                        break;
                    case "radioButtonCocuk":
                        VeriOlustur.SiparisEkle(2);
                        break;
                }
            }
            
            button1.PerformClick();
        }

        private void buttonSat_Click(object sender, EventArgs e)
        {
            var radioBtn = this.Controls
                .OfType<RadioButton>().FirstOrDefault(x => x.Checked);

            var adet = textBoxAdet.Text;
            int.TryParse(adet, out var adetSayi);
            
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "radioButtonCocuk":
                        VeriOlustur.SatisEkle(0, adetSayi);
                        break;
                    case "radioButtonBayan":
                        VeriOlustur.SatisEkle(1, adetSayi);
                        break;
                    case "radioButtonErkek":
                        VeriOlustur.SatisEkle(2, adetSayi);
                        break;
                }
            }
            satilanUrunlerButton.PerformClick();
        }
        #endregion
    }
}