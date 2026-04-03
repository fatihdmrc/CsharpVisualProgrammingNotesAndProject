using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Programlama_Hafta_5_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        // TableLayout panel Propoertilerinde GrowthSize özelliği FixedSize yapılarak 
        //fazladan sütun ve satır eklememesi için ayarladık.
        double Sonuc = 0;
        string islem = "";
        bool islemSeciliMi = false;
        bool yeniSayiGirilecekMi = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void sayilar_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender; // Hangi butonun tıklandığını sender yardımı ile buton'da yakalıyoruz.
            if (yeniSayiGirilecekMi)
            {
                lblSayi.Text = ""; // Eğer yeni sayı giriliyorsa lblSayıyı temizler
                yeniSayiGirilecekMi = false;
            }
            if (buton.Text == "-/+") // tıklanan buton -/+ butonu ise
            {
                if (lblSayi.Text != "") // girilen sayı boş değilse
                {
                    lblSayi.Text = "" + Double.Parse(lblSayi.Text) * -1; // sayıyı - ile çarp
                }
            }
            else if (buton.Text == ",") // tıklanan buton virgül butonu ise
            {
                if(lblSayi.Text=="") // girilen sayı boşsa
                {
                    lblSayi.Text = "0,";
                }
                if(!lblSayi.Text.Contains(",")) // sayıda virgül varsa
                {
                    lblSayi.Text = lblSayi.Text + ",";
                }
               
            }
            else // eğer sayılardan herhangi bir butona tıklandıysa
            {
                if (lblSayi.Text == "0")
                {
                    lblSayi.Text = "";
                }
                lblSayi.Text = lblSayi.Text + buton.Text;
            }

        }
        private void Islemler_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender; // hangi işlem butonuna tıkladığını buton ile yakaladım
            if (islemSeciliMi)
            {
                btnEsittir.PerformClick(); // btnEsittire tiklandığında yapılacak işlem yapılacak
            }
            else
            {
                Sonuc = double.Parse(lblSayi.Text);
            }
            islem = buton.Text;
            lblİslemler.Text = Sonuc + islem;
            yeniSayiGirilecekMi = true;
            islemSeciliMi = true;
        }
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (islemSeciliMi)
            {
                string gecmis = lblİslemler.Text + "" + lblSayi.Text + " = ";
                switch (islem)
                {
                    case "+":
                        lblSayi.Text = (Sonuc + double.Parse(lblSayi.Text)).ToString();
                        break;
                    case "-":
                        lblSayi.Text = (Sonuc - double.Parse(lblSayi.Text)).ToString();
                        break;
                    case "*":
                        lblSayi.Text = (Sonuc * double.Parse(lblSayi.Text)).ToString();
                        break;
                    case "/":
                        lblSayi.Text = (Sonuc / double.Parse(lblSayi.Text)).ToString();
                        break;
                    default:
                        break;
                }
                Sonuc = double.Parse(lblSayi.Text);
                listBoxGecmis.Items.Add(gecmis+Sonuc);
                lblİslemler.Text = "";
                lblİslemler.Text = Sonuc + " " + islem;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblSayi.Text = "0";
            yeniSayiGirilecekMi = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnCE.PerformClick();
            islem = "";
            lblİslemler.Text = "";
            islemSeciliMi = false;
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();
            listBoxGecmis.Items.Clear();
        }
    }
}
