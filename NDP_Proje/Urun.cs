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

namespace NDP_Proje
{
    /*
     * Ürünler sınıfı. Bu sınıfta ürünlerin bilgilerini oluşturan property'ler vardır.
     */
    public class Urun
    {
        private readonly Random gen = new Random(Guid.NewGuid().GetHashCode());

        public Urun()
        {
            Musteri = new Musteri();
            Tedarikci = new Tedarikci();

            TarihAta();
            FiyatAta();
            AdetAta();
        }

        public Stok Stok { get; protected set; }
        public Tedarikci Tedarikci { get; }
        public double Alis { get; private set; }
        public double Satis { get; private set; }
        public DateTime AlisTarihi { get; private set; }
        public DateTime SatisTarihi { get; private set; }

        public Musteri Musteri { get; }

        private void AdetAta()
        {
            Stok = new Stok();
        }

        private void FiyatAta()
        {
            // Ürünlerin satış ücreti alış ücreti üzerinden hesaplanıyor
            // %10'luk bir kar için alış ücreti 1.1 ile çarpılır
            Alis = gen.Next(10, 50);
            Satis = Alis * 1.1;
        }

        // Örnek tarih atamalarının yapıldığı yer
        private void TarihAta()
        {
            AlisTarihi = new DateTime(2022, 5, 1);
            AlisTarihi = AlisTarihi.AddDays(gen.Next((AlisTarihi.AddDays(7) - AlisTarihi).Days));
            SatisTarihi = AlisTarihi.AddDays(1);
        }
    }
}