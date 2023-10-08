namespace C_Tekrar
{
    public partial class FaktoriyelHesaplamaFormu : Form
    {
        public FaktoriyelHesaplamaFormu()
        {
            InitializeComponent();
        }
        void FaktoriyelBul()
        {
            int faktoriyel = 1;
            int sayý = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayý; i++)
            {
                faktoriyel = faktoriyel * i;
                label1.Text = faktoriyel.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FaktoriyelBul();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}