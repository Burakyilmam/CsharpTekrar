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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(textBox1.Text);
            if (comboBox1.Text == "Karesi")
            {
                MessageBox.Show("Değer : " + Math.Pow(sayı, 2));
            }
            else if (comboBox1.Text == "Küpü")
            {
                MessageBox.Show("Değer : " + Math.Pow(sayı, 3));
            }
            else if (comboBox1.Text == "Karekökü")
            {
                MessageBox.Show("Değer : " + Math.Sqrt(sayı));
            }
        }
    }
}
