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
    public partial class DörtİşlemFormu : Form
    {
        public DörtİşlemFormu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textBox1.Text);
            int sayı2 = Convert.ToInt32(textBox2.Text);
            Hesapla(sayı1, sayı2);
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        void Hesapla(int sayı1, int sayı2)
        {
            if (comboBox1.Text == "Toplama")
            {
                int sonuc = sayı1 + sayı2;
                label1.Text = sonuc.ToString();
            }
            else if (comboBox1.Text == "Çıkarma")
            {
                int sonuc = sayı1 - sayı2;
                label1.Text = sonuc.ToString();
            }
            else if (comboBox1.Text == "Çarpma")
            {
                int sonuc = sayı1 * sayı2;
                label1.Text = sonuc.ToString();
            }
            else if (comboBox1.Text == "Bölme")
            {

                int sonuc = sayı1 / sayı2;
                label1.Text = sonuc.ToString();

            }
        }
    }
}
