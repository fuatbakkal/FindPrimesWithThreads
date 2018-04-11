using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class AnaForm : Form
    {
        private static int alinan, thread_sayisi, bolen_sayisi;
        private static CancellationTokenSource IptalSinyali;
        private static readonly int gecikme = 1; //Araştırılacak sayılar arasındaki gecikme
        private static bool bayrak_basla = false, bayrak_bitir = false, bayrak_IlkAcilis = false;
        private static string bolenler_text = "", bolunuyormu_text;
        private static readonly string html_bas = "<html><body style=\"background-color: #F0F0F0\"><span style=\"font-size: 12px; font-family: Microsoft Sans Serif; font-weight: bold;\">";
        private static readonly string html_son = "</span></body></html>";

        public AnaForm()
        {
            InitializeComponent();
        }

        private void MainWork(int sayi)
        {
            Invoke((MethodInvoker)delegate
            {
                arastirilan_text.Text = sayi.ToString();
                dgv.Rows.Clear();
            });

            bolen_sayisi = 0;
            bolenler_text = "";
            SQL Sql = new SQL();
            int eleman_sayisi = Sql.ElemanSayisi((int)Math.Sqrt(sayi)); //Tabloda tavan sayısına kadar kaç tane asal sayı var
            thread_sayisi = (eleman_sayisi / 5) + 1;

          /*  if (eleman_sayisi <= 100)
                thread_sayisi = 2;*/

            int aralik = (int)Math.Ceiling((double)eleman_sayisi / thread_sayisi);
            Thread[] threadler = new Thread[thread_sayisi];

            for (int i = 0; i < thread_sayisi; i++)
            {
                bolunuyormu_text = "Hayır";
                int offset;

                if (eleman_sayisi % 2 == 0) //Eleman sayısı tek ise
                    offset = i % 2;         //ortadaki eleman ilk threadin sonu
                                            //son threadin başı olsun
                else
                    offset = 0;

                int bas = i * (aralik - 1) + 1 + offset; //Başlangıç indeksi
                int son = bas + aralik - 1; //Bitiş indeksi
                object prms = new object[4] { bas, son, sayi, i }; //Başlangıç, Bitiş, Araştırılacak Sayı, Thread No
                threadler[i] = new Thread(() => { AsalMi(prms); });
                threadler[i].Start(); // Child threadleri başlat

                while (threadler[i].ThreadState == System.Threading.ThreadState.Running) //Child threadler sonlanmadan
                {                                                                        //MainThread'e dönme
                    Thread.Sleep(1);
                }

                //threadler[i].Join(); //Her thread bir öncekinin sonlanmasını beklesin mi?

                //Threadleri ekrandaki tabloya yaz
                Invoke((MethodInvoker)delegate
                {
                    if (i == thread_sayisi - 1)
                        dgv.Rows.Add(i, Sql.ElamaniBul(son), Sql.ElamaniBul(bas), bolunuyormu_text);

                    else
                        dgv.Rows.Add(i, Sql.ElamaniBul(bas), Sql.ElamaniBul(son), bolunuyormu_text);

                    //Son hücreyi renklendir
                    if (String.Equals("Evet", bolunuyormu_text))
                        dgv.Rows[i].Cells[3].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#8cff1a");

                    else
                        dgv.Rows[i].Cells[3].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff471a");
                });
            }

            Invoke((MethodInvoker)delegate
            {
                if (bolen_sayisi > 0)
                {
                    sonuc_text.ForeColor = Color.Red;
                    sonuc_text.Text = "Sayı asal değildir!";
                    BolenleriYaz(bolenler_text);
                }

                else
                {
                    BolenleriYaz("");
                    sonuc_text.ForeColor = Color.Green;
                    sonuc_text.Text = "Sayı asaldır!";
                    Thread thread_SqlEkle = new Thread(() => Sql_Ekle(alinan));
                    thread_SqlEkle.Start();
                    thread_SqlEkle.Join();
                }
            });
        }

        private void MainThread(CancellationToken ct)
        {
            while (true)
            {
                if (ct.IsCancellationRequested)
                {
                    try
                    {
                        ct.ThrowIfCancellationRequested();
                    }

                    catch
                    {
                        break;
                    }
                }

                alinan = alinan + 2;
                MainWork(alinan);
                Thread.Sleep(gecikme); // Araştırılan sayılar arası gecikme
            }
        }

        private async Task MainTask()
        {
            IptalSinyali = new CancellationTokenSource();
            var sw = new Stopwatch();

            try
            {
                sw.Start();
                await Task.Run(() => MainThread(IptalSinyali.Token)); //Asenkron görevi başlat
            }

            catch (OperationCanceledException)
            {
                return;
            }

            sw.Stop();
        }

        private async void basla_Click(object sender, EventArgs e)
        {
            if (bayrak_basla)
                return; //Üst üste tıklanırsa bir şey yapma

            else
            {
                bayrak_IlkAcilis = false;
                bayrak_basla = true;
                bayrak_bitir = false;
                await MainTask();
            }
        }

        private void bitir_Click(object sender, EventArgs e)
        {
            if (bayrak_bitir || bayrak_IlkAcilis)
                return; //Üst üste tıklanırsa bir şey yapma

            else
            {
                bayrak_bitir = true;
                bayrak_basla = false;
                IptalSinyali.Cancel();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            bayrak_IlkAcilis = true;
            BolenleriYaz(bolenler_text);
            SQL Sql = new SQL();
            alinan = Sql.SonEleman() + 2;
            MainWork(alinan); // Program ilk defa çalıştırıldığında yapılacak iş
        }

        private static void AsalMi(object prms)
        {
            SQL Sql = new SQL();
            Array prmdizi = new object[4];
            prmdizi = (Array)prms;
            int bas = (int)prmdizi.GetValue(0);
            int son = (int)prmdizi.GetValue(1);
            int sayi = (int)prmdizi.GetValue(2);
            int tn = (int)prmdizi.GetValue(3);

            if (tn == thread_sayisi - 1) //Son Thread'de tersten bak.
            {
                for (int i = son; i >= bas; i--)
                {
                    if (sayi % Sql.ElamaniBul(i) == 0)
                    {
                        bolen_sayisi++;
                        bolenler_text += ("Thread " + tn + "'da bulunan <span style=\"color: blue; \">" + Sql.ElamaniBul(i) + "</span> sayısına bölünüyor.<br />");
                        bolunuyormu_text = "Evet";
                        //break; //bölündüğü ilk sayıyı bulduğunda döngüyü kır?
                    }
                }
            }

            else
            {
                for (int i = bas; i <= son; i++)
                {
                    if (sayi % Sql.ElamaniBul(i) == 0)
                    {
                        bolen_sayisi++;
                        bolenler_text += ("Thread " + tn + "'da bulunan <span style=\"color: blue; \">" + Sql.ElamaniBul(i) + "</span> sayısına bölünüyor.<br />");
                        bolunuyormu_text = "Evet";
                        //break; //bölündüğü ilk sayıyı bulduğunda döngüyü kır?
                    }
                }
            }

            return;
        }

        private static void Sql_Ekle(int sayi)
        {
            SQL Sql = new SQL();
            Sql.ElemanEkle(sayi);
            Thread.Sleep(0);
            return;
        }

        private void BolenleriYaz(string text)
        {
            bolenler_sonuc.DocumentText = "0";
            bolenler_sonuc.Document.OpenNew(true);
            bolenler_sonuc.Document.Write(html_bas + text + html_son);
            bolenler_sonuc.Refresh();
        }
    }
}