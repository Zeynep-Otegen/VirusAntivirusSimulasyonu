using System;
using System.Drawing;
using System.Windows.Forms;

namespace VirusAntivirusSimulasyonu
{
    public partial class Form1 : Form
    {
        // Virüsün kalbi: Fareyi sürekli merkeze çeken zamanlayıcı
        private Timer payloadTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeVirusEngine();
        }

        private void InitializeVirusEngine()
        {
            payloadTimer = new Timer();
            payloadTimer.Interval = 5; // 5ms - Fareyi kurtarmayı imkansız kılar
            payloadTimer.Tick += (s, e) => {
                // Ekranın tam ortasını bul
                int centerX = Screen.PrimaryScreen.Bounds.Width / 2;
                int centerY = Screen.PrimaryScreen.Bounds.Height / 2;
                Cursor.Position = new Point(centerX, centerY);
            };
        }

        private void btnInfect_Click(object sender, EventArgs e)
        {
            payloadTimer.Start();
            lblStatus.Text = "TEHLİKE: Fare Kilitlendi!";
            lblStatus.ForeColor = Color.Red;
            Log("Saldırı başlatıldı: Cursor hapsedildi.");
            Log("İpucu: Kurtulmak için TAB ile butona gelip ENTER yapın.");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            payloadTimer.Stop();
            lblStatus.Text = "GÜVENLİ: Tehdit Temizlendi.";
            lblStatus.ForeColor = Color.Lime;
            Log("Antivirüs çalıştırıldı: Payload durduruldu.");
            Log("Sistem onarıldı, fare serbest.");
        }

        private void Log(string message)
        {
            listLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] {message}");
            listLog.TopIndex = listLog.Items.Count - 1;
        }
    }
}