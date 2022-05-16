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
     * Stok sınıfı.
     * Her ürünün bir stok değeri vardır. Bu değerler lokal olarak atandığı için private set kullandım
     */
    public class Stok
    {
        public Stok()
        {
            UrunYerleriniAta();
        }

        public Stok(int depoda, int rafta)
        {
            UrunYerleriniAta(depoda, rafta);
        }

        public int DepodakiUrunler { get; private set; }
        public int RaftakiUrunler { get; private set; }

        /*
         * Stok atamalarını rastgele yaptım.
         */
        private void UrunYerleriniAta()
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());
            var index = rand.Next(10, 100);
            DepodakiUrunler = index;
            index = rand.Next(10, 100);
            RaftakiUrunler = index;
        }
        
        private void UrunYerleriniAta(int depoda, int rafta)
        {
            DepodakiUrunler = depoda;
            RaftakiUrunler = rafta;
        }
    }
}