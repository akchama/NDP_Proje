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

namespace NDP_Proje
{
    /* Her ürünün bir satış ve alış günü vardır
     */
    public class Gun
    {
        private readonly List<Urun> _urunler;

        public Gun(List<Urun> urunler, DateTime gun)
        {
            _urunler = urunler;
            GununTarihi = gun;

            // Satılan ve alınan ürünleri hesaplamak için LINQ kullandım
            var satilanUrunler = _urunler.Where(u => u.SatisTarihi == gun);
            SatisToplamlar = satilanUrunler.Sum(urun => urun.Satis);

            var alinanUrunler = _urunler.Where(u => u.AlisTarihi == gun);
            AlisToplamlar = alinanUrunler.Sum(u => u.Alis);
        }

        // Atamalar local olarak sınıf içerisinde yapıldığı için property'lerde sadece
        // get metodunu tanımladım
        public DateTime GununTarihi { get; }
        public double SatisToplamlar { get; }
        public double AlisToplamlar { get; }
    }
}