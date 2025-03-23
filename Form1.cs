using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pizza_Sipariş_Ekranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.AddRange(new string[]
            {
                "Small 120Tl",
                "Medium 150TL",
                "Large 210Tl",
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HesaplaToplam();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HesaplaToplam();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            HesaplaToplam();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplam();
        }

        private void HesaplaToplam()
        {
            textBox2.Enabled = false;
            double toplamfiyat = 0;
            int adet = 0;

            if (int.TryParse(txtAdet.Text, out adet) && adet > 0)
            {
                string secilenboyut = comboBox1.SelectedItem.ToString();

                if (secilenboyut == "Small 120Tl")
                {
                    toplamfiyat += 120 * adet;
                }
                else if (secilenboyut == "Medium 150TL")
                {
                    toplamfiyat += 150 * adet;
                }
                else if (secilenboyut == "Large 210Tl")
                {
                    toplamfiyat += 210 * adet;
                }

                if (radioButton1.Checked)
                {
                    toplamfiyat += 15 * adet;
                }
            }

            textBox2.Text = toplamfiyat.ToString();
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz alındı!");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}