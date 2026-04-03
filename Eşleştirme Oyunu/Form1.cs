using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Form da dock özelliği yoktur
// Form da StartPosition özelliği vardır. CenterScreen ekranın ortasında.
// WindowsDefaultLocation da sol üst köşede başlar
// CenterParent ise içinde bulunduğu formun yada objenin tam merkezinde açılır.
namespace Görsel_Programlama_Hafta_2
{
    public partial class Form1 : Form
    {
        Label etk_1 = null;
        Label etk_2 = null;

        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k","k","b","b","v","v","w","w","z","z"
        };
        private void hucrelereResimAta()
        {
            /* 
             tableLayoutPanel1 'in içindeki tüm nesneleri alacak ve tek tek döngü çalışırken
            Control tipindeki etk değişkeninin içine atacak.
             */
            // Control sınıfı formdaki elemanları veya araçları temsil eder.
            foreach (Control etk in tableLayoutPanel1.Controls)
            {
                Label resEtk = etk as Label; // etk Control olduğu için bunu Label olarak almasını tanımlıyoruz.
                if (resEtk != null)
                {
                    int rs = random.Next(icons.Count);
                    resEtk.Text = icons[rs];
                    resEtk.ForeColor = resEtk.BackColor;
                    icons.RemoveAt(rs);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            hucrelereResimAta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // tableLayoutPanel aracının Dock özelliğini Fill yaptığımızda tüm formu otomatik olarak kaplar
            // tableLayoutPanel özelliklerini kullanarak satır ve sütun ekledik. Bunların oranlarının da belirledik.
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }

            Label tiklananEtiket = sender as Label;
            /*
            hangi obje tetiklendiyse sender objesinde oluyor.
            Label türünde bir değişken oluşturup sender ile hangi objeye tıkladıysak bunu değişkene aktarıyoruz.
            */
            if (tiklananEtiket != null)
            {
                if (tiklananEtiket.ForeColor == Color.Black)
                {
                    return;
                }
                if (etk_1 == null)
                {
                    etk_1 = tiklananEtiket;
                    etk_1.ForeColor = Color.Black;
                    return;
                }

                etk_2 = tiklananEtiket;
                etk_2.ForeColor = Color.Black;

                if (etk_1.Text == etk_2.Text)
                {
                    etk_1 = null;
                    etk_2 = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            etk_1.ForeColor = etk_1.BackColor;
            etk_2.ForeColor = etk_2.BackColor;
            etk_1=null;
            etk_2=null;
        }
    }
}
