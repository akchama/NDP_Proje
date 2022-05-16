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

namespace NDP_Proje
{
    // Mağaza için giderler sınıfı
    public class Giderler : Magaza
    {
        public double Eleman { get; set; }
        public double Yemek { get; set; }
        public double Elektrik { get; set; }
        public double Kira { get; set; }
        
        // Giderleri toplayıp geri dönderen fonksiyon
        public double GiderleriHesapla()
        {
            return Eleman + Yemek + Elektrik + Kira;
        }
    }
}