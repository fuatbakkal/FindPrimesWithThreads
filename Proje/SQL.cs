using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Proje
{
    class SQL
    {
        private MySqlConnection baglanti;
        private string sunucu;
        private string veritabani;
        private string kullanici;
        private string sifre;

        public SQL()      // Kurucu fonksiyon
        {                 // SQL'den nesne oluşturulduğunda Baglanti()
            Baglanti();   // ve ResetAI() fonksiyonunu çalıştır.
            ResetAI();    // AUTO_INCREMENT değerini sıfırla.
        }

        private void Baglanti()
        {
            sunucu = "localhost";
            veritabani = "yazlab";
            kullanici = "kou";
            sifre = "HuVywme95HmCqqLC";
            string BaglantiCumlesi = "SERVER=" + sunucu + ";" + "DATABASE=" +
            veritabani + ";" + "UID=" + kullanici + ";" + "PASSWORD=" + sifre + ";";
            baglanti = new MySqlConnection(BaglantiCumlesi);
        }

        private bool BaglantiKur()
        {
            try
            {
                baglanti.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("MySQL sunucusuna bağlanılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return false;
            }
        }

        private bool BaglantiKapat()
        {
            try
            {
                baglanti.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void ResetAI()
        {
            string sorgu = "ALTER TABLE sayilar AUTO_INCREMENT = 1";

            if (BaglantiKur())
            {
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                BaglantiKapat();
                return;
            }
        }

        public int SonEleman()
        {
            string sorgu = "SELECT sayi FROM sayilar WHERE no = (SELECT MAX(no) FROM sayilar)";

            if (BaglantiKur())
            {
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader veri_oku = komut.ExecuteReader();
                veri_oku.Read();
                int sayi = Convert.ToInt32(veri_oku["sayi"]);
                veri_oku.Close();
                BaglantiKapat();

                return sayi;
            }

            else
                return 0;
        }

        public int ElemanSayisi(int tavan)
        {
            string sorgu = "SELECT Count(sayi) FROM sayilar WHERE sayi <= " + Convert.ToString(tavan);

            if (BaglantiKur())
            {
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader veri_oku = komut.ExecuteReader();
                veri_oku.Read();
                int sayi = Convert.ToInt32(veri_oku["Count(sayi)"]);
                veri_oku.Close();
                BaglantiKapat();

                return sayi;
            }

            else
                return 0;
        }

        public int ElamaniBul(int indeks)
        {
            string sorgu = "SELECT sayi FROM sayilar WHERE no = " + Convert.ToString(indeks);

            if (BaglantiKur())
            {
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader veri_oku = komut.ExecuteReader();
                veri_oku.Read();
                int sayi = Convert.ToInt32(veri_oku["sayi"]);
                veri_oku.Close();
                BaglantiKapat();

                return sayi;
            }

            else
                return 0;
        }

        public void ElemanEkle(int eleman)
        {
            string sorgu = "INSERT INTO sayilar VALUES (DEFAULT, '" + Convert.ToString(eleman) + "')";

            if (BaglantiKur())
            {
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                BaglantiKapat();
            }

            else
                return;
        }
    }
}