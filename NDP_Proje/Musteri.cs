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
    /* Müşteri sınıfı. Müşterinin ismini barındırmaktadır. Müşterilere listeden
     * seçilen rastgele bir isim atanmaktadır.
     */
    public class Musteri
    {
        public Musteri()
        {
            string[] musteriler =
            {
                "Karabükey",
                "Mihrican",
                "Ayşete",
                "Alpcan",
                "Bediha",
                "İdi",
                "Erdim"
            };

            var rand = new Random(Guid.NewGuid().GetHashCode());
            var index = rand.Next(musteriler.Length);
            AdSoyad = musteriler[index];
        }

        public string AdSoyad { get; }
    }
}