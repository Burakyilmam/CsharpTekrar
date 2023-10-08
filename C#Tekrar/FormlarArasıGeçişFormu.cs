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
    public partial class FormlarArasıGeçişFormu : Form
    {
        public FormlarArasıGeçişFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FaktoriyelHesaplamaFormu frm = new FaktoriyelHesaplamaFormu();
            frm.Show();
            this.Hide();
        }
    }
}
