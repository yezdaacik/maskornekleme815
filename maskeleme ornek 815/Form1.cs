using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maskeleme_ornek_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 12;
                    txtBilgi.Text += String.Format("Çorba {0:C}", nCorba.Value * 12) + "\r\n";
                }

                txtBilgi.Text += "-----------------";
                txtBilgi.Text += String.Format("Toplam {0:C}", hesap);
            }

            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi2.Text = "";
                txtBilgi2.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi2.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (nCorba.Value > 0)
                {
                    hesap += nSalata.Value * 12;
                    txtBilgi2.Text += String.Format("Salata {0:C}", nSalata.Value * 12) + "\r\n";
                }

                txtBilgi2.Text += "-----------------";
                txtBilgi2.Text += String.Format("Toplam {0:C}", hesap);
            }

            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi3.Text = "";
                txtBilgi3.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi3.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (nYemek.Value > 0)
                {
                    hesap += nYemek.Value * 12;
                    txtBilgi3.Text += String.Format("Ana Yemek {0:C}", nYemek.Value * 12) + "\r\n";
                }

                txtBilgi3.Text += "-----------------";
                txtBilgi3.Text += String.Format("Toplam {0:C}", hesap);
            }

            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi4.Text = "";
                txtBilgi4.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi4.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (nTatli.Value > 0)
                {
                    hesap += nSalata.Value * 12;
                    txtBilgi4.Text += String.Format("Tatlı {0:C}", nTatli.Value * 12) + "\r\n";
                }

                txtBilgi4.Text += "-----------------";
                txtBilgi4.Text += String.Format("Toplam {0:C}", hesap);
            }
   
        }

        private void txtBilgi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
