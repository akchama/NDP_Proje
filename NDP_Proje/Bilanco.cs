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

namespace NDP_Proje
{
    /*
     * Toplam gelir ve giderlerin hesaplandığı sınıf. burada oluşturulan DateTime tarihleri
     * günlere atanmaktadır.
     */
    public class Bilanco
    {
        private readonly List<Urun> _urunler;

        public Bilanco(List<Urun> urunler)
        {
            Gunler = new List<Gun>();

            _urunler = urunler;
            GelirGiderHesapla();
        }

        public List<Gun> Gunler { get; }

        private void GelirGiderHesapla()
        {
            for (var i = 1; i < 8; i++) Gunler.Add(new Gun(_urunler, new DateTime(2022, 5, i)));
        }
    }
}