using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Programlama_Hafta_4_Analog_Saat
{
    // Location 0;0 olarak ayarlandığında tam sol üst köşeye nesne yerleşir
    public partial class Form1 : Form
    {
        Bitmap akrepResim; // Bitmap piksel tabanlı resimleri düzenlemek için oluşturulmuş bir sınıftır.
        Bitmap yelkovanResim;
        Bitmap saniyeResim;
        Bitmap milisaniyeResim;
        int aci = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pctrbxAkrep.Parent = pctrbxSaat; // akrep, kadranın alt elemanı oldu. Bu şekilde kadranın üstünde gözükebilecek. Akrepin arka planı da transparan olduğu için 
            pctrbxAkrep.Location = new Point(0, 0); // akrep'i parent'ı olan Kadranın tam sol üstüne hizalanacak şekilde konumunu belirledik
            akrepResim = new Bitmap(Görsel_Programlama_Hafta_4_Analog_Saat.Properties.Resources.akrep); // Bitmap'e resmi aktardık.
            pctrbxYelkovan.Parent = pctrbxAkrep;
            pctrbxYelkovan.Location = new Point(0, 0);
            yelkovanResim = new Bitmap(Görsel_Programlama_Hafta_4_Analog_Saat.Properties.Resources.yelkovan);
            pctrbxSaniye.Parent = pctrbxYelkovan;
            pctrbxSaniye.Location = new Point(0, 0);
            saniyeResim = new Bitmap(Görsel_Programlama_Hafta_4_Analog_Saat.Properties.Resources.saniye);
            pctrbxMiliSaniye.Parent = pctrbxSaniye;
            pctrbxMiliSaniye.Location = new Point(0, 0);
            milisaniyeResim = new Bitmap(Görsel_Programlama_Hafta_4_Analog_Saat.Properties.Resources.mili);
        }


        private Bitmap cevir(Bitmap eskiResim, float aci)
        {
            Bitmap dondurulmusResim = new Bitmap(eskiResim.Width, eskiResim.Height);
            using (Graphics g = Graphics.FromImage(dondurulmusResim))
            {
                g.TranslateTransform(eskiResim.Width / 2, eskiResim.Height / 2);
                g.RotateTransform(aci);
                g.TranslateTransform(-eskiResim.Width / 2, -eskiResim.Height / 2);
                g.DrawImage(eskiResim, new Point(0, 0));
            }
            return dondurulmusResim;
        }
        DateTime zaman;
        int saat;
        int dakika;
        int saniye;
        int milisaniye;
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            saat = zaman.Hour;
            dakika = zaman.Minute;
            saniye = zaman.Second;
            milisaniye = zaman.Millisecond;
            lblSaat.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", saat, dakika, saniye, milisaniye);
            Single milisaniyeaci = milisaniye * 360 / 1000;
            Single saniyeaci = 6 * saniye + milisaniyeaci/60;
            Single dakikaaci = 6 * dakika +saniyeaci/60 ;
            Single saataci = saat * 30 + dakikaaci/12;

            pctrbxAkrep.Image = cevir(akrepResim, saataci);
            pctrbxYelkovan.Image = cevir(yelkovanResim, dakikaaci);
            pctrbxSaniye.Image = cevir(saniyeResim, saniyeaci);
            pctrbxMiliSaniye.Image = cevir(milisaniyeResim, milisaniyeaci);
        }
    }
}
