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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(textBox1.Text);
            int toplam = 0, cift = 0, ciftsayı = 0, tek = 0, teksayı = 0;

            for (int i = 1; i <= sayı; i++)
            {
                toplam = toplam + i;
            }
            MessageBox.Show("Toplam : " + toplam);
            for (int j = 1; j <= sayı; j++)
            {
                if (j % 2 == 0)
                {
                    ciftsayı = ciftsayı + 1;
                    cift = cift + j; ;
                }
                else
                {
                    teksayı = teksayı + 1;
                    tek = tek + j; ;

                }
            }
            MessageBox.Show(ciftsayı + 1 + " Sayı çifttir ve değerleri toplamı : " + cift);
            MessageBox.Show(teksayı + " Sayı tektir ve değerleri toplamı : " + tek);
            MessageBox.Show("Çift sayıların ortalaması : " + cift / ciftsayı);
            MessageBox.Show("Tek sayıların ortalaması : " + tek / teksayı);


        }
    }
}
