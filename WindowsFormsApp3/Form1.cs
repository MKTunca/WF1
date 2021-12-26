using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 5; x >= 1; x--)
            {
                for (int y = x; y >= 1; y--)
                {
                    rtb.Text = rtb.Text + "*";
                }
            }
            rtb.Text = rtb.Text + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1.Text = sayi1.Text.Replace(".", ",");

            sayi2.Text = sayi2.Text.Replace(".", ",");
            double s1 = Convert.ToDouble(sayi1.Text);
            double s2 = Convert.ToDouble(sayi2.Text);
            double deger = s1 * s2;
            sonuc.Text = deger.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Int32 indexNo = epostaTXT.Text.IndexOf("@");
            if(indexNo!=-1)
            {
                if(indexNo!=0)
                {
                    MessageBox.Show("doğrulandı");
                }
            }   else
            {
                MessageBox.Show("hatalı");
            }
                
        }
    }
}
