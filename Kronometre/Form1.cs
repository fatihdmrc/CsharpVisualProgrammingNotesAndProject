using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Programlama_Hafta_3_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch kronometre = new Stopwatch();
        /* 
         Stopwatch kütüphanesi c#'ın kendi içindeki kronometresidir.
         */
        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (!kronometre.IsRunning) // kronometre çalışmıyorsa
            {
                kronometre.Start(); // kronometreyi başlat
                timer1.Start();
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            if (kronometre.IsRunning) //kronometre çalışıyorsa
            { kronometre.Stop(); } // kronometreyi durdur
            
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            lblSüre.Text = "00:00:00:000";
            kronometre.Reset();
        }
        /* 
         Aslında burda Timer'ın görevi her 1 milisaniyede sürekli olarak
         Kronometre Stopwatch'ında geçen süreyi bir timespan türünde değişkenin içine atıyor.
        Ve bu değişkeni label'a her 1 milisaniyede sürekli yazdırıyor.
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kronometre.IsRunning) 
            {
                // kronometre çalışıyorsa
                TimeSpan ts = kronometre.Elapsed;
                // TimeSpan zaman aralığı alır
                // kronometrenin elapsed özelliği ile geçen zamanı ts 'nin içine attık
                lblSüre.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lstbxSüreler.Items.Add(lblSüre.Text); // LblSüre yi listboxa ekliyor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstbxSüreler.Items.Clear(); // Listbox'u temizliyor
        }
    }
}
