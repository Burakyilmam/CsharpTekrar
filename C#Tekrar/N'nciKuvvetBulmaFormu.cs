using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Tekrar
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı = Convert.ToDouble(textBox1.Text);
            double kuvvet = Convert.ToDouble(textBox2.Text);
            double toplam = 1;
            for (int i = 0; i < kuvvet; i++)
            {
                toplam = toplam * sayı;
            }
            MessageBox.Show("Değer : " + toplam);

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
