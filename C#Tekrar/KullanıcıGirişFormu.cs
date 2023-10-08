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
    public partial class KullanıcıGirişFormu : Form
    {
        public KullanıcıGirişFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            if (Username == "Admin" && Password == "123")
            {
                DörtİşlemFormu form3 = new DörtİşlemFormu();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
