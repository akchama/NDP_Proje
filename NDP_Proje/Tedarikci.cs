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
     * Her ürünün bir tedarikçisi vardır. Tedarikçilerin oluşturulup isimlerinin atandığı sınıf.
     */
    public class Tedarikci
    {
        // Tedarikcilerin siparişleri vardır
        public Siparis Siparis { get; set; }

        public Tedarikci()
        {
            string[] tedarikciler =
            {
                "Dinçsel",
                "Gürçay",
                "Tansuhan",
                "Onultan",
                "Balkiyan",
                "Mugaddes",
                "Ant",
                "Tağman",
                "Fatigül",
                "Dilfuzar",
                "Erşet",
                "Cezayir",
                "Cihaner",
                "Teköktem",
                "Sunguralp",
                "Gülsevin",
                "Bilgesu",
                "Arıbal",
                "Alisevim",
                "Said"
            };

            var rand = new Random(Guid.NewGuid().GetHashCode());
            var index = rand.Next(tedarikciler.Length);
            AdSoyad = tedarikciler[index];
        }

        public string AdSoyad { get; }
    }
}