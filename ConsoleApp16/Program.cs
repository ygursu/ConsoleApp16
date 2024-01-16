using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstanbul_Kart_Örnek_Uygulama
{
    public partial class Form1 : Form
    {
        double bakiye = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = bakiye.ToString();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            bakiye += 50;
            lblBakiye.Text = bakiye.ToString();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            bakiye += 100;
            lblBakiye.Text = bakiye.ToString();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            bakiye += 200;
            lblBakiye.Text = bakiye.ToString();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            double odeme = 0;

            if (cbOgrenci.Checked)
            {
                if (rbAktarma0.Checked)
                {
                    odeme = 7.32;
                }
                else if (rbAktarma1.Checked)
                {
                    odeme = 3.21;
                }
                else if (rbAktarma2.Checked)
                {
                    odeme = 3.02;
                }
                else
                {
                    odeme = 2.58;
                }
            }
            else
            {
                if (rbAktarma0.Checked)
                {
                    odeme = 15;
                }
                else if (rbAktarma1.Checked)
                {
                    odeme = 10.75;
                }
                else if (rbAktarma2.Checked)
                {
                    odeme = 8.15;
                }
                else
                {
                    odeme = 5.15;
                }
            }


            //ödeme burada yapılıyor
            if (bakiye < odeme)
            {
                MessageBox.Show("Yürümek de güzeldir.");
            }
            else
            {
                bakiye = bakiye - odeme;
            }

            lblBakiye.Text = bakiye.ToString();
        }
    }
}

